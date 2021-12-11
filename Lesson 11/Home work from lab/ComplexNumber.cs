using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_from_lab
{
    class ComplexNumber
    {
        int real;
        int imaginary;
        public ComplexNumber(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public static ComplexNumber operator +(ComplexNumber num_1, ComplexNumber num_2)
        {
            return new ComplexNumber(num_1.real + num_2.real, num_1.imaginary + num_2.imaginary);
        }
        public static ComplexNumber operator -(ComplexNumber num_1, ComplexNumber num_2)
        {
            return new ComplexNumber(num_1.real - num_2.real, num_1.imaginary - num_2.imaginary);
        }
        public static ComplexNumber operator *(ComplexNumber num_1, ComplexNumber num_2)
        {
            return new ComplexNumber(num_1.real * num_2.real - num_1.imaginary * num_2.imaginary, num_1.real * num_2.imaginary + num_2.real * num_1.imaginary);
        }
        public static bool operator ==(ComplexNumber num_1, ComplexNumber num_2)
        {
            return num_1.real == num_2.real && num_1.imaginary == num_2.imaginary;
        }
        public static bool operator !=(ComplexNumber num_1, ComplexNumber num_2)
        {
            return num_1.real != num_2.real || num_1.imaginary != num_2.imaginary;
        }
        public override string ToString()
        {
            return $"Комплексное число: вещественная часть {real}, мнимая часть {imaginary}";
        }
    }
}
