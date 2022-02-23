namespace Peladas_WEBAPI.Models
{
    public class Agendamento
    {
        
        public Agendamento(){}
        public Agendamento( int peladaId, int usuarioId)
        {
        
            this.peladaId = peladaId;
            this.usuarioId = usuarioId;

        }
       
        public int peladaId { get; set; }
        public virtual Pelada Pelada { get; set; }
        public int usuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        //nossa tabela N to N
    }
}