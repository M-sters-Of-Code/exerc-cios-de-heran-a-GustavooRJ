// See https://aka.ms/new-console-template for more information
using SistemaBancario.Model;

Cliente cliente1 = new Cliente("Maria", "12345678900");
Conta conta1 = new Conta(cliente1);

Console.WriteLine($"A conta número {conta1.Numero} pertence a(o) cliente {conta1.Titular.Nome} com saldo de R$ {conta1.Saldo}");

ContaEspecial conta2 = new ContaEspecial(1000, 500);
Conta conta3 = new ContaEspecial(2000, 1000);

conta3.Depositar(500);
conta3.Sacar(3000);

Console.WriteLine($"Conta especial \nSaldo restante após o saque: R$ {conta3.Saldo}");

Cliente cliente4 = new Cliente("João", "29445195950");
ContaCaixinha contaCaixinha = new ContaCaixinha(cliente4);

contaCaixinha.Depositar(50);
contaCaixinha.Sacar(10);

Console.WriteLine($"Conta caixinha \nSaldo final: R${contaCaixinha.Saldo}");