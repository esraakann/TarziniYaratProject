using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarziniYaratProject.DAL.Concrete.EntityFramework
{
    class TarziniYaratInitializer:CreateDatabaseIfNotExists<TarziniYaratDBContext>
    {
        protected override void Seed(TarziniYaratDBContext context)
        {
            //TODO: Başlangıçta eklenmesi istenen yapılar buraya yazılabilir.
            base.Seed(context);
        }
    }
}
