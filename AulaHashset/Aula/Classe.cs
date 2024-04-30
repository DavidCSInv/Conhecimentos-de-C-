using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
     class Classe
    {
        public int Aluno { get; set; }

        public Classe (int aluno)
        {
            Aluno = aluno;
        }
        public override int GetHashCode()
        {
            return Aluno.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj == null))
                return false;
            Classe other = obj as Classe;

            return Aluno.Equals(other.Aluno);
        }
    }
}
