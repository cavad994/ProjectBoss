using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSS
{
    public class CV
    {
        public string Ixtisas { get; set; }
        public string School { get; set; }
        public double UnivercityScore { get; set; }
        public string Skills { get; set; }
        public string Companies { get; set; }
        public string Languages { get; set; }
        public bool Diplom { get; set; }
        
        public CV(string ıxtisas, string school, double univercityScore,
                    string skills, string companies, string languages,
                    bool diplom)
        {
            Ixtisas = ıxtisas;
            School = school;
            UnivercityScore = univercityScore;
            Skills = skills;
            Companies = companies;
            Languages = languages;
            Diplom = diplom;
        }
    }
}
