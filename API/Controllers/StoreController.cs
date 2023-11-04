using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private IStoreDomain _storeDomain;
        private IStoreData _storeData;

        public StoreController(IStoreDomain storeDomain, IStoreData storeData)
        {
            _storeDomain = storeDomain;
            _storeData = storeData;
        }
        
        // GET: api/Store
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //StoreData storeData = new StoreData();

            //storeData.GetAll();
            return new string[] { "value1", "value2" };
        }

        // GET: api/Store/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            //StoreSQLData storeSqlData = new StoreSQLData();
            //return storeSqlData.GetAll();
            
            return _storeData.GetById(id);
        }

        // POST: api/Store
        [HttpPost]
        public bool Post([FromBody] string value)
        {
           /// StoreDomain storeDomain = new StoreDomain();

           return _storeDomain.create(value);

           // return storeDomain.Create(value);
        }

        // PUT: api/Store/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Store/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
