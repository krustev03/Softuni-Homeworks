using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Repositories
{
    public class GunRepository : IRepository<IGun>
    {
        private IList<IGun> models;

        public GunRepository()
        {
            this.models = new List<IGun>();
        }

        public IReadOnlyCollection<IGun> Models => this.models.ToList().AsReadOnly();

        public void Add(IGun model)
        {
            if (this.models.Any(x => x == model) == false)
            {
                this.models.Add(model);
            }
        }

        public IGun Find(string name)
        {
            var gun = this.models.FirstOrDefault(x => x.Name == name);

            return gun;
        }

        public bool Remove(IGun model)
        {
            bool hasRemoved = this.models.Remove(model);

            return hasRemoved;
        }
    }
}
