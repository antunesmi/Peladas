using System.Collections.Generic;

namespace Peladas_WEBAPI.Models
{
    public class LocalP
    {

    public LocalP(){

    }
    public LocalP(int localPId, string nomeLocal, string apelido)
    {
        this.localPId = localPId;
        this.nomeLocal = nomeLocal;
        this.apelido = apelido;

    }
    public int localPId { get; set; }
    public string nomeLocal { get; set; }
    public string apelido { get; set; }
    
    //Vínculo de relacionamneto


    
    }
}

