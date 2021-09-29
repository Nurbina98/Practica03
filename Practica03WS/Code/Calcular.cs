using System;

namespace Practica03WS.Code
{
    public class Calcular
    {

        public double Cuadrado(int K)
        {
            var result = K * K;
            return result;
        }

        public double Triangulo(int D, int G)
        {
            var result = (D * G) / 2;
            return result;
        }

        public double Circulo(int A)
        {
            var result = Math.PI * Math.Pow(A, 2);
            return result;
        }

    }
}