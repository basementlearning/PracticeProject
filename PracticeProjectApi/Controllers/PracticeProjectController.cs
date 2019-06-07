using Microsoft.AspNetCore.Mvc;
using PracticeProjectApi.Models;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PracticeProjectApi.Controllers
{
	[Route("api/[controller]")]
	public class PracticeProjectController : ControllerBase
	{


		//===============================================
		//creating a private context variable DI to use
		//in the class in the constructor...
		//===============================================
		private readonly PracticeContext _context;
		public PracticeProjectController(PracticeContext context)
		{
			_context = context;
		}




		// GET: api/<controller>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<controller>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<controller>
		[HttpPost]
		public void Post([FromBody]string value)
		{
		}

		// PUT api/<controller>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/<controller>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
