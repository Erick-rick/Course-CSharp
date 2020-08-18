using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio_V___Transações_Bancaria
{
    class Conta
    {
        public  int NumberConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
       
        public Conta(int conta, string nome) {
            NumberConta = conta;
            Titular = nome;
       
        }

        public Conta(int conta, string nome, double saldo) : this (conta, nome)
        {
            NumberConta = conta;
            Titular = nome;
            Depositar(saldo);
        }


        public double Depositar(double valor){
            return Saldo += valor; 
         }


        public double Sacar(double valor) {
            return Saldo -= valor  + 5.00;
        }

        public override string ToString() { 
            return  
                 "Conta : " + NumberConta + ", "
                + "Titular: " + Titular + ", " 
                + "Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
                
        }
        
        }

    }

