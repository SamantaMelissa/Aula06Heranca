namespace Aula06Heranca
{
    public class CPF: Pessoa // <---- Herança da super clasee "Pessoa"//
    {
        //atributos//
        public string cpf;

        public string rg;

        public bool ValidarCPF(){
            //Colocar nessa sequência para seguir essa sequência!!//
            if (cpf !=null){
                return true;
            }
            return false;
        }

        //método//


    }
}