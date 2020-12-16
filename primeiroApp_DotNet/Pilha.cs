using System;

namespace primeiroApp_DotNet
{

    public class Pilha
    {

        Posicao primero;

        public void Empilha(object item)
        {
            primero = new Posicao(primero, item);

        }
        public object Desempilha()
        {
            if (primero == null)
            {

                throw new InvalidOperationException();
            }
            object result = primero.item;
            primero = primero.proximo;
            return result;
        }

        class Posicao
        {
            public Posicao proximo;
            public object item;


            public Posicao(Posicao proximo, object item)
            {
                this.proximo = proximo;
                this.item = item;

            }
        }



    }
}