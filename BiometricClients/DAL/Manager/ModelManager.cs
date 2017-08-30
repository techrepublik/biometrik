using BiometricClients.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometricClients.DAL.Manager
{
    class ModelManager
    {
        public static DataRepository<Model> _d;
        public static int Save(Model model)
        {
            var a = new Model
            {
                ModelId = model.ModelId,
                ModelName = model.ModelName
            };
            using (_d = new DataRepository<Model>())
            {
                if (model.ModelId > 0)
                    _d.Update(a);
                else _d.Add(a);
                _d.SaveChanges();
            }
            return a.ModelId;
        }

        public static bool Delete(Model model)
        {
            using (_d = new DataRepository<Model>())
            {
                _d.Delete(model);
                _d.SaveChanges();
            }
            return true;
        }
        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Model>())
            {
                _d.Delete(_d => _d.ModelId == iId);
                _d.SaveChanges();
            }
            return true;
        }
        public static List<Model> GetAll()
        {
            using (_d = new DataRepository<Model>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().OrderBy(o => o.ModelName).ToList();
            }
        }
        public static Model Get()
        {
            using (_d = new DataRepository<Model>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.FirstOrDefault(f => f.ModelId == 1);
            }
        }
        
        }
    }


   
