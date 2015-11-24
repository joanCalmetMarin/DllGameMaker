using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace DllGameMaker
{
    public class Class1
    {
        //Hay que usar grafia pascal para publicos empezar la primera letra de cada palabra en mayuscula en privado es primero barrabaja
        //la primera palabra en minuscula y la siguiente con la primera letra en mayuscula Ejemplos
        public int NoMeToquesLosCojones;
        private int _zampaMeUnTesticulo; 

        //variables basicas par consultar valores maximos y minimos san google
        int aux; //variable entera de negativo a positivo
        uint a; //variable entera positiva
        float a1; //variable con coma de positivo a negativo
        double a2; //la variable mas grande de todas con coma y de positivo a negativo
        bool a3; // o tambien bolean que es una variable de true o falso

        //variables especiales
        Tuple<object, object> a4;// la tubla es un objeto que contiene muchos objetos de cualquier tipo un ejemplo seria Tupla<int,int> que contiene
                    //un par de enteros tambien puede contener clases
        Dictionary<object, object> a5; //es una tupla que va indexada por la key que es el primer valor por lo tanto si tu creas una con key 5
                         //puedes hacceder directamente al registro poniendo a5[5] no va por orden se ordenan segun la key
        List<object> a6;//de la misma forma que la tupla este almacena una lista de elementos cualquiera, pueden ser tuplas clases de todo
                        //para añadir elementos usar el submetodo .Add(Elemento);
        BitArray a7;    //es una array de boleanos 

        //tipo de variables y metodos
        private object a8; //el private hace que ninguna otra clase pueda acceder a este valor
        public object a9; //el publico puede ser escrito por qualquie otra clase 
        internal object a10; //el internal solo puede ser escrito dentro del mismo proyecto
        protected object a11; //el modo protected hace que solo pueda escribir los eredados
        virtual public object a12(); //el modo virtual permite que los que erende de esta clase sobre escriban este metodo en este caso
        //puede ser publico, privado... se vebe usar el modo OVERRIDE para sobre escribir
        abstract public a13(); //el modo abstracto obliga a los que ereden a implementar este metodo se vebe usar el modo OVERRIDE

        //para hacer herencia de datos se hace con : nombre de la clase en la generacion de la clase
        //todo esto seria lo basico intentare crear clases para que podais ir viendo ejemplos
        
    }
}
