using System;

namespace Cshar
{
    class Persona{

        private string nombre;
        private string apellido;
        private int edad;

        public Persona(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }


        public Persona(string apellido, string nombre, int edad){

            setNombre(nombre);
            setApellido(apellido);
            setEdad(edad);
        }

        public Persona()
        {
            setNombre("");
            setApellido("");
            setEdad(0);
        }

        public int Edad
        {
            get { return edad;}
            set { edad = value;}
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value;}
        }

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        
        public void setNombre(string nombre){ this.nombre = nombre;}
        public string getNombre(){return nombre;}

        public void setApellido(string apellido) { this.apellido = apellido;}
        public string getApellido() { return apellido;}

        public void setEdad(int edad) { this.edad = edad;}
        public int getEdad() { return edad;}


        public new string ToString => "\nNombre: {0}" + Nombre + "Apellido: {1}" + Apellido + "Edad: {2}" + Edad + " años \n", getNombre();

        //public string informacion() { return "\nNombre: {0} Apellido: {1} Edad: {2} años \n", Nombre, Apellido, Edad};


    }


    class Empleado : Persona {

        private String legajo;

        public Empleado(String legajo){

            setLegajo(legajo);
        }

        public Empleado(){

            setLegajo(" ");
        }

        public void setLegajo(String legajo) {this.legajo = legajo;}
        public String getLegajo() {return legajo;}
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Saludar(nombre);

            Restar(13, 4);
            Sumar(2);
            Console.WriteLine(multiplicar(5, 2));

            Console.WriteLine(Potencia(7, 5));
            Console.WriteLine(Potencia(9));
            Console.WriteLine(Potencia(a: 4, b: 3));

            int resultado = areaRectangulo(alto: 50, ancho: 7);
            Console.WriteLine("Area rectangulo {0}", resultado);

            int m = 10;
            Console.WriteLine("Valor de x {0} antes de la referencia",m);
            Referencia(ref m);
            Console.WriteLine("Valor de x {0} despues de la referencia", m);

            int x = 3 , y = 33;
            Console.WriteLine("Dentro de main el valor de x: {0} y el  valor de y: {1}", x, y);
            getValores(out x, out y);
            Console.WriteLine("despues de la funcion el valor de x: {0} y el  valor de y: {1}", x, y);


            //DibujarPiramide(5);

            int factorial = Factorial(5);
            Console.WriteLine("Factorial de 5:  {0}", factorial);

            Console.WriteLine("Factorial de 6:  "+ Factorial(6));

            Sumar__(a: 7, b: 11);

            int abc;
            int xyz = Test(out abc);
            Console.WriteLine(abc + xyz);

            Persona persona1 = new Persona("Alex", "Echeverria", 22);
            Console.WriteLine(persona1.ToString);

            Persona persona2 = new Persona("Gustavo", "Echeverria", 49);
            persona2.Edad = 10;
            Console.WriteLine(persona2.ToString);


            //Console.WriteLine("Edad: " + persona2.Edad{getValores});



            Empleado empleado = new Empleado("");

            int[] arreglo1 = new int [10];
            
            int[] arreglo2 = new int[] {1,2,3,4,5,6,7,8,9,10};

            int[] arreglo3 = new int[] { };

            string[] arreglo4 = new string[4] {"Alex", "Maira", "Laura", "Gustavo"};

            string[] arreglo5 = new string[ ] {"Alex","Maira", "Laura", "Gustavo" };

            string[] arreglo6 = new string[] { };

            string[] arreglo7 = { "Alex", "Maira", "Laura", "Gustavo" };


            foreach (var leido in arreglo2)
            {
                Console.WriteLine(leido);
            }
         

        }

        static void Saludar(string n)
        {
            Console.WriteLine("Hello {0} !", n);
        }

        static void Restar(int a, int b)
        {
            int total = a + b;
            Console.WriteLine(total);
        }

        static void Sumar(int a, int b = 2)
        {
            int total = a + b;
            Console.WriteLine(total);
        }

        static int multiplicar(int a, int b)
        {
            return a * b;
        }

        static int Potencia(int a, int y = 2, int b = 0)
        {
            int resultado = 0;

            for (int i = 0; i < y; i++)
            {
                resultado += a;
            }
            return resultado;
        }

        static int areaRectangulo(int alto, int ancho)
        {
            return alto * ancho;
        }

        static void Referencia(ref int x)
        {
            x = x * x;
        }

        static void getValores(out int x, out int y)
        {
            x = 7;
            y = 17;
            Console.WriteLine("Dentro de la funcion el valor de x: {0} y el  valor de y: {1}", x, y);
        }

        static void DibujarPiramide(int n)
        {
            for(int i=0; i<n; i++)
            {
                for(int j =0; j<n; i++)
                {
                    Console.WriteLine(" ");
                }

                for(int k=0; k<2*i-1; k++)
                {
                    Console.WriteLine("*" + " ");
                }
                Console.WriteLine();
            }
        }

        static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        static void Sumar__(int a=8, int b = 8)
        {
            Console.WriteLine(a * b);
        }

        static int Test(out int x, int y = 4)
        {
            x = 6;
            return x * y;
        }


    }

    private void Holamunditoalex()
    {
        int a = 10;

        int b = 20;

        int c = a + b;


    }
}



