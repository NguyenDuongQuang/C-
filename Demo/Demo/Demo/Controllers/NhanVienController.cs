using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Demo.Models;

namespace Demo.Controllers
{
    public class NhanVienController : ApiController
    {
        testEntities nv = new testEntities();
        [HttpGet]
        [Route("api/NhanVien/DanhSach")]
        public List<nhan_vien> getAll()
        {
            return nv.nhan_vien.ToList();
        }


        [HttpPost]

      
        public IHttpActionResult Post(nhan_vien v)
        {
            if (getAll().Any(y => y.id == v.id))
            {
                return BadRequest();
            }
            nv.nhan_vien.Add(v);
            nv.SaveChanges();
            return Ok();
        }


        [HttpPut]
       
        public IHttpActionResult Put(nhan_vien v) {
            nhan_vien n = nv.nhan_vien.FirstOrDefault(z => z.id == v.id);
            if (n == null) { 
                return NotFound();
            }
            n.name = v.name;
            n.email= v.email;
            n.gender = v.gender;
            n.age = v.age;
            nv.SaveChanges();
            return Ok(n);
        }

        [HttpDelete]
    
        public IHttpActionResult Delete(int  id)
        {
            nhan_vien n = nv.nhan_vien.FirstOrDefault(z => z.id ==id);
            if (n == null)
            {
                return NotFound();
            }
            nv.nhan_vien.Remove(n);
            nv.SaveChanges();
            return Ok();
        }

        public nhan_vien getSerch(int id)
        {
            return nv.nhan_vien.FirstOrDefault(x=> x.id == id);
        }

    }

}
