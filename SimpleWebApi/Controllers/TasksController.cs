using Microsoft.AspNetCore.Mvc;
using SimpleWebApi.Models.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpPut("Task1")]
        public int GetTask1(int[] array)
        {
            return TaskWork.Task1(array);
        }

        [HttpPut("Task2")]
        public bool GetTask2(string text)
        {
            return TaskWork.Task2(text);
        }

        [HttpPut("Task3")]
        public int[] GetTask3(int[] array)
        {
            return TaskWork.Task3(array).GetItems();
        }

    }
}
