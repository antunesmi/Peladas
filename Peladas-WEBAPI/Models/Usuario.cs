using System.Collections.Generic;

namespace Peladas_WEBAPI.Models
{
    public class Usuario
    {
        //construtor passado sem parametro
        public Usuario() {
            
        }
        //parecida com a base usada no frontend
        public Usuario(int usuarioId, string nomeCompleto, string apelido, 
                        string email, string senha)
        {
            this.usuarioId = usuarioId;
            this.nomeCompleto = nomeCompleto;
            this.apelido = apelido;
            this.email = email;
            this.senha = senha;

        }
        public int usuarioId { get; set; }
        public string nomeCompleto { get; set; }
        public string apelido { get; set; }
        public string email { get; set; }
        public string senha{ get; set;}

       // vinculo do relacionamento
         public virtual IEnumerable<Agendamento> Agendamentos { get; set; }




    }
}