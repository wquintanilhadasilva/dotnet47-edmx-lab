using System;
using System.Collections.Generic;
using System.Linq;

using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ValuesController : ApiController
    {

        // GET api/values
        public List<pessoa> Get()
        {
            List<pessoa> pessoas = new List<pessoa>();
            using (var ctx = new BikeTeste())
            {

                var pf = new pessoa_fisica
                {
                    cpf = "2345678",
                    name = "pessoa fisica"
                };
                var pj = new pessoa_juridica
                {
                    cnpj = "875421",
                    name = "pessoa juridica"
                };
                ctx.pessoa.Add(pf);
                ctx.pessoa.Add(pj);
                ctx.SaveChanges();

                pessoas = ctx.pessoa.ToList();

            }
            return pessoas;

        }

        //// GET api/values
        //public List<personsSet> Get()
        //{
        //    List<personsSet> persons = new List<personsSet>();
        //    using(var ctx = new BikeTeste())
        //    {

        //        var pf = new pessoa_fisica
        //        {
        //            cpf = "2345678",
        //            name = "pessoa fisica"
        //        };
        //        var pj = new pessoa_juridica
        //        {
        //            cnpj = "875421",
        //            name = "pessoa juridica"
        //        };
        //        ctx.pessoa.Add(pf);
        //        ctx.pessoa.Add(pj);
        //        ctx.SaveChanges();

        //        #region old
        //        var fisic = new personsSet_FisicPerson
        //        {
        //            cpf = "987654321",
        //            name = "Person 1",
        //            Id = 1
        //        };
        //        var jur = new personsSet_juridicpersons
        //        {
        //            cnpj = "12345678910121314",
        //            name = "Person 2",
        //            Id = 2
        //        };
        //        ctx.personsSet.Add(fisic);
        //        ctx.personsSet.Add(jur);
        //        ctx.SaveChanges();

        //        persons = ctx.personsSet.ToList();

        //        #endregion

        //    }
        //    return persons;

        //}

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
