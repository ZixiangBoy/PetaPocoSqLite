using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UltraDbEntity;

namespace PetaPocoDemo {
    class Program {
        static void Main(string[] args) {

            using (var db = new Database("UltraDbEntity")) {
                var user = new t_user() { 
                    CreateDate=DateTime.Now,
                    Guid=Guid.NewGuid(),
                    Creator="admin",
                    IsUsing=true,
                    Pwd="123",
                    UserName="admin"
                };

                var result=user.Insert();

            }
        }
    }
}
