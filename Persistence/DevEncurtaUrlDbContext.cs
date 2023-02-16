using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevEncurtaUrl.API.Entities;

namespace DevEncurtaUrl.API.Persistence
{
    public class DevEncurtaUrlDbContext
    {
        private int _currentIndex = 1;
        public DevEncurtaUrlDbContext()
        {
            Links = new List<ShortenedCustomLink>();
        }

        public List<ShortenedCustomLink> Links { get; set; }

        public void Add(ShortenedCustomLink link){
            link.Id = _currentIndex;

            _currentIndex ++;
            Links.Add(link);
        }
    }
}