// using Microsoft.AspNetCore.Mvc;
// using QuestionsApi.Models;
// using System.Collections.Generic;

// namespace QuestionsApi.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class QuestionsController : ControllerBase
//     {
//         // List of questions stored in memory (no database)
        // List<Question> questions = new List<Question>
        // {
        //     new Question
        //     {
        //         Id = "1",
        //         QuestionText = "What is the purpose of the Common Language Runtime (CLR) in .NET?",
        //         Options = new List<string> { "Memory Management", "Handles the code execution", "Data Serialization", "User Interface Design" },
        //         Correct = "1"
        //     },
        //     new Question
        //     {
        //         Id = "2",
        //         QuestionText = "Which of the following is used to define an API endpoint in a .NET application?",
        //         Options = new List<string> { "Web API Controller", "MVC Controller", "Web Service", "Razor Page" },
        //         Correct = "0"
        //     },
        //     new Question
        //     {
        //         Id = "3",
        //         QuestionText = "Which .NET collection is used to store key-value pairs?",
        //         Options = new List<string> { "List<T>", "Dictionary<TKey, TValue>", "Queue<T>", "HashSet<T>" },
        //         Correct = "1"
        //     },
        //     new Question
        //     {
        //         Id = "4",
        //         QuestionText = "Which method is used to read data from a file in .NET?",
        //         Options = new List<string> { "File.ReadAllText", "File.Open", "StreamReader.ReadLine", "File.WriteAllText" },
        //         Correct = "0"
        //     },
        //     new Question
        //     {
        //         Id = "5",
        //         QuestionText = "What is the difference between a value type and a reference type in .NET?",
        //         Options = new List<string> { "Value types store data directly; reference types store references to data", "Reference types are faster than value types", "Value types can be null; reference types cannot", "There is no difference" },
        //         Correct = "0"
        //     },
        //     new Question
        //     {
        //         Id = "6",
        //         QuestionText = "In C#, which of the following is used to handle exceptions?",
        //         Options = new List<string> { "try-catch block", "throw", "finally", "using" },
        //         Correct = "0"
        //     },
        //     new Question
        //     {
        //         Id = "7",
        //         QuestionText = "Which of the following is used to create a new thread in a .NET application?",
        //         Options = new List<string> { "Thread.Start", "Task.Run", "ThreadPool.QueueUserWorkItem", "All of the above" },
        //         Correct = "3"
        //     },
        //     new Question
        //     {
        //         Id = "8",
        //         QuestionText = "Which of the following is the entry point of a .NET application?",
        //         Options = new List<string> { "Main() method", "Start() method", "OnInit() method", "Run() method" },
        //         Correct = "0"
        //     },
        //     new Question
        //     {
        //         Id = "9",
        //         QuestionText = "In .NET, what does the 'async' keyword signify?",
        //         Options = new List<string> { "The method is asynchronous", "The method will throw an exception", "The method will return a Task", "The method will execute synchronously" },
        //         Correct = "0"
        //     },
        //     new Question
        //     {
        //         Id = "10",
        //         QuestionText = "Which of the following is a feature of Entity Framework in .NET?",
        //         Options = new List<string> { "Automatic migration", "Code-first and database-first approaches", "CRUD operations with minimal code", "All of the above" },
        //         Correct = "3"
        //     }
        // };

//         [HttpGet]
//         public IActionResult GetQuestions()
//         {
//             return Ok(questions);
//         }

//         // POST: api/questions
//         [HttpPost]
//         public IActionResult PostQuestion([FromBody] Question newQuestion)
//         {
//             if (newQuestion == null)
//             {
//                 return BadRequest("Question data is null.");
//             }

//             // Add the new question to the list in memory
//             questions.Add(newQuestion);

//             // Return a 201 Created response with the newly added question
//             return CreatedAtAction(nameof(GetQuestions), new { id = newQuestion.Id }, newQuestion);
//         }
//     }
// }




using Microsoft.AspNetCore.Mvc;
using QuestionsApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace QuestionsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        // List of questions stored in memory (no database)
                List<Question> questions = new List<Question>
        {
            new Question
            {
                Id = "1",
                QuestionText = "What is the purpose of the Common Language Runtime (CLR) in .NET?",
                Options = new List<string> { "Memory Management", "Handles the code execution", "Data Serialization", "User Interface Design" },
                Correct = "1"
            },
            new Question
            {
                Id = "2",
                QuestionText = "Which of the following is used to define an API endpoint in a .NET application?",
                Options = new List<string> { "Web API Controller", "MVC Controller", "Web Service", "Razor Page" },
                Correct = "0"
            },
            new Question
            {
                Id = "3",
                QuestionText = "Which .NET collection is used to store key-value pairs?",
                Options = new List<string> { "List<T>", "Dictionary<TKey, TValue>", "Queue<T>", "HashSet<T>" },
                Correct = "1"
            },
            new Question
            {
                Id = "4",
                QuestionText = "Which method is used to read data from a file in .NET?",
                Options = new List<string> { "File.ReadAllText", "File.Open", "StreamReader.ReadLine", "File.WriteAllText" },
                Correct = "0"
            },
            new Question
            {
                Id = "5",
                QuestionText = "What is the difference between a value type and a reference type in .NET?",
                Options = new List<string> { "Value types store data directly; reference types store references to data", "Reference types are faster than value types", "Value types can be null; reference types cannot", "There is no difference" },
                Correct = "0"
            },
            new Question
            {
                Id = "6",
                QuestionText = "In C#, which of the following is used to handle exceptions?",
                Options = new List<string> { "try-catch block", "throw", "finally", "using" },
                Correct = "0"
            },
            new Question
            {
                Id = "7",
                QuestionText = "Which of the following is used to create a new thread in a .NET application?",
                Options = new List<string> { "Thread.Start", "Task.Run", "ThreadPool.QueueUserWorkItem", "All of the above" },
                Correct = "3"
            },
            new Question
            {
                Id = "8",
                QuestionText = "Which of the following is the entry point of a .NET application?",
                Options = new List<string> { "Main() method", "Start() method", "OnInit() method", "Run() method" },
                Correct = "0"
            },
            new Question
            {
                Id = "9",
                QuestionText = "In .NET, what does the 'async' keyword signify?",
                Options = new List<string> { "The method is asynchronous", "The method will throw an exception", "The method will return a Task", "The method will execute synchronously" },
                Correct = "0"
            },
            new Question
            {
                Id = "10",
                QuestionText = "Which of the following is a feature of Entity Framework in .NET?",
                Options = new List<string> { "Automatic migration", "Code-first and database-first approaches", "CRUD operations with minimal code", "All of the above" },
                Correct = "3"
            }
        };

        // GET: api/questions
        [HttpGet]
        public IActionResult GetQuestions()
        {
            return Ok(questions);
        }

        // POST: api/questions
        [HttpPost]
        public IActionResult PostQuestion([FromBody] Question newQuestion)
        {
            if (newQuestion == null)
            {
                return BadRequest("Question data is null.");
            }

            // Generate a new unique ID for the new question
            newQuestion.Id = (questions.Count + 1).ToString();

            // Add the new question to the list in memory
            questions.Add(newQuestion);

            // Return a 201 Created response with the newly added question
            return CreatedAtAction(nameof(GetQuestions), new { id = newQuestion.Id }, newQuestion);
        }

        // DELETE: api/questions/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteQuestion(string id)
        {
            var questionToDelete = questions.FirstOrDefault(q => q.Id == id);

            if (questionToDelete == null)
            {
                return NotFound("Question not found.");
            }

            // Remove the question from the list
            questions.Remove(questionToDelete);

            // Return a 204 No Content response after successful deletion
            return NoContent();
        }
    }
}
