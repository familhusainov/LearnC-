using EntityCodeFirstExamLib;
using EntityCodeFirstExamLib.Models;
using LearnApi.Model.PostModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController : ControllerBase
    {
        

        private readonly SchoolContext schoolContext;
        public GradeController( SchoolContext schoolContext)
        {           
            this.schoolContext = schoolContext;
        }
        [HttpGet("getAll")]
        public IActionResult GetAll() // hamisin getir
        {
            var grades = schoolContext.Grades.ToList();
         
            return Ok(grades);
        }
        [HttpGet("get/{id}")]
        public IActionResult Get(int id) // id-ye gore getir
        {
            var grade = schoolContext.Grades.Where(x=>x.Id==id).SingleOrDefault();
            return Ok(grade);
        }
        [HttpGet("getById")]
        public IActionResult GetById(int id) // id-ye gore getir
        {
            var grade = schoolContext.Grades.Where(x => x.Id == id).SingleOrDefault();
            return Ok(grade);
        }
        [HttpPut("put")]
        public IActionResult Put(Grade model) // update  deyisdirmek
        {
            var oldData = schoolContext.Grades.Where(x => x.Id == model.Id).Single();
            oldData.GradeName = model.GradeName;
            oldData.Section= model.Section;
            schoolContext.Grades.Update(oldData);
            var result =  schoolContext.SaveChanges();
            return Ok($"Ok updated id={model.Id}");
        }
        [HttpPost("post")]
        public IActionResult Post(GradePostModel model) // insert daxil etmek
        {
            if (model.Section == null)
                throw new Exception("Section is required field");
            if (model.GradeName == null)
                throw new Exception("Grade is required field");
            var newGrade = new Grade() 
            {
                Id = model.Id,
                Section = model.Section, 
                GradeName = model.GradeName 
            };
            schoolContext.Grades.Add(newGrade);
            var result = schoolContext.SaveChanges();
            return Ok($"Ok inserted id={newGrade.Id}");
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int id, int id2) // delete
        {
            var oldData = schoolContext.Grades.Where(x => x.Id == id).Single();
            schoolContext.Grades.Remove(oldData);
            var oldData1 = schoolContext.Grades.Where(x => x.Id == id2).Single();
            schoolContext.Grades.Remove(oldData1);
            schoolContext.SaveChanges();
            return Ok("succesfully removed");
        }

        [HttpGet("testError")]
        public IActionResult testError(int? grade) // delete
        {
            string message =string.Empty;
            bool IsConnected = false;   
            IsConnected = true;
            try
            {
                // som codes

                if (grade <= 11)
                    message = $"{grade} sinif";
                else if (grade == null)
                    throw new NullReferenceException("grade is null");
                else
                    throw new Exception("Unknown grade");

            }
            catch (NullReferenceException ex) {
                return StatusCode(501, ex.Message);
            }
            catch (Exception ex)
            {
                // log yaz some codes
                //message = "bu univessitet telebesidir";
                // throw;

                return StatusCode(500, ex.Message);

            }
            finally
            {
                IsConnected = false;
            }


            return Ok(message);
        }





    }
}
