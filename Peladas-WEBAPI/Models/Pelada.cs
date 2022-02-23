using System;
using System.Collections.Generic;

namespace Peladas_WEBAPI.Models
{
    public class Pelada
    {
        public Pelada(){
            
        }
        public Pelada(int peladaId, string nomeEvento, string dataEvento, 
            string horaEvento, DateTime dataAgend, int localPId)

            
          {
                               
            this.peladaId = peladaId;
            this.nomeEvento = nomeEvento;
            this.dataEvento =  DateTime.Parse(dataEvento);
            this.horaEvento = DateTime.Parse(horaEvento);
            this.dataAgend = dataAgend;
            this.localPId = localPId;
            
            
            }
        public int peladaId { get; set; }
        public string nomeEvento { get; set; }
        public DateTime dataEvento { get; set; }
        public DateTime horaEvento { get; set; }
        //o agemdamento pega data e hora autómatico
        public DateTime  dataAgend { get; set; }
        
        public int localPId { get; set; }
        //apenas um local
        public LocalP LocalP { get; set; }
       
       public virtual IEnumerable<Agendamento> Agendamentos { get; set; }
        
        
        

    }

}