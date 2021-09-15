
//------------NIVEL 1------------//

public int calcularAR (int BT, int AT)
{
	int x = BT * AT;
	int y = x/2;
	return y;
}
int AR = calcularAR(6,2);
//area do triangulo


public double perimetro (double lado)
{
	double per = lado * 8;
	return per;
}
double octogono = perimetro(12);
//perimetro de um octogono


public double trap (double bm, double bn, double al)
{
	double area = ((bm + bn) * al) / 2;
	return area;
}
double area = trap(10, 4, 5);
//area de um trapezio

public double losangulo (double dm, double dn)
{
	double area = (dm * dn) / 2;
	return area;
}
double area = losangulo(10,7);
//area de um losangulo

public double paralelogramo (double b, double a)
{
	double area = b *a;
	return area;
}
double area = paralelogramo(10,7);
//area de um paralelogramo



//------------NIVEL 2------------//

using System;
public double hipopotamo(double co, double ca)
{
	double catetos = (co * co) + (ca * ca);
	double	x = Math.Sqrt(catetos);
	return x;
}
double hipotenusa = hipopotamo(5,5);
//calcular a hipotenusa

using System;
public double IMC1 (double peso, double altura)
{
	double calculo = peso / (Math.Pow(altura,2));
	double arredondar = Math.Round(calculo,2);
	return arredondar;
}
double IMC = IMC1(80, 1.8);
//calcularo IMC

using System;
public double juros (double capital, int parc, double taxa)
{
	double x = capital * parc * taxa /100;
	double y = x + capital;
	double abacate = Math.Round(y, 1);
	return abacate;
}
double x = juros (2000, 4, 10);
//calcularos juros compostos

using System;
public double energia(double massa, double velocidade)
{
	double Ec = (massa * Math.Pow(velocidade,2) / 2);
	return Ec; 
}
double x = energia(4000, 10);
//energia cinetica

public double CalcularVolumeCilindro (double raio, double altura)
{
    double volume= 3.14 * Math.Pow(raio, 2) * altura;
	return volume;
}
double x = CalcularVolumeCilindro(2, 3);
//volume cilindro





//------------NIVEL 3------------//

using System;
public string nome (string nomecom)
{
	string d = nomecom.Substring(0,nomecom.IndexOf(' '));
	return d;
}
string x = nome("Lucas da Silva Farias");
//primeiro nome



public string dominio (string email)
{
	string d = email.Substring(email.IndexOf('@'));
	return d;
}
string qualdom = dominio("asda.asdasta6545@acaofatima.com");
// saber o dominio

public bool cep (string seucep)
{
	int abacate = seucep.Length; 
	bool batata = seucep.Contains("-") && abacate == 9;
	return batata;
}
bool x = cep("04763-200");
//cep

public string cell (string celular)
{
	string test = celular.Replace("(", "").Replace(")","").Replace(" ","").Replace("-","");
	return test;
}
 string x = cell("(11) 93143-8025");
//celular sem mascara


//------------NIVEL 4------------//



using System;
public DateTime primeirodia (DateTime data)
{
    DateTime e = new DateTime(data.Year, data.Month, 1);
    DateTime proximo = e.AddMonths(1);
    return proximo;
}
DateTime a = new DateTime(2021,06,09);
DateTime x = primeirodia(a);
//primeiro dia do mês

using System;
public DateTime arroz(DateTime data)
{
DateTime ultimo = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));
return ultimo;
}
DateTime x = new DateTime(2021,01,12);
DateTime y = arroz(x);
//ultimo Dia Do Mes

using System; 
public bool trimestre (DateTime data)
{
int mes = data.Month; 
bool z = mes  == 4 || mes == 5 || mes == 6;
return z;
}
bool x =  trimestre (new DateTime(2021,01,01));
//se pertence ao segundo trimestre

using System;
public bool quinzena (DateTime data)
{
    int x = data.Day;
    bool pertence = x >= 1 && x <= 15;
    return pertence;
}
DateTime x = new DateTime(2021,04,08);
bool pertence = quinzena(x);
//primeira quinzena do mês


//------------NIVEL 5------------//

using System;
public string bh(double a1, double b1, double c1)
{
	double x1 = bh1(a1, b1, c1);
	double x2 = bh2(a1, b1, c1);
	string x3 = "o valor do X1 é " +x1 " e o valor do X2 é " + x2;
	return x3;
}    
public double bh1(double a1, double b1, double c1)
{
   double delta = Math.Pow(b1, 2) - (4 * a1 * c1);
   double delta2 = Math.Sqrt(delta);
   double x1 = (((b1 * (-1)) + delta2) / (2 * a1));
   return x1;
}
public double bh2(double a2, double b2, double c2)
{
   double delta = Math.Pow(b2, 2) - (4 * a2 * c2);
   double delta2 = Math.Sqrt(delta);
   double x2 = (((b2 * (-1)) - delta2) / 2 * a2);
   return x2;
}
//equação de segundo grau


using System;
public bool elibra (DateTime data1, DateTime data2)
{
	bool p1 = ver(data1);
	bool p2 = ver(data2);
	return p1 == true && p2 == true;
}

public bool ver (DateTime data)
{
	bool x1 = data.Month == 9 && data.Day > 22;
	bool x2 = data.Month == 10 && data.Day < 23;
	return x1 == true || x2 == true;
}
DateTime a = new DateTime(1989, 9 ,30);
DateTime b = new DateTime(1989, 10, 25);
bool z = elibra(a, b);
//verificar se os dois são de libra


using System;
public bool msm (string n1, string n2)
{
	string x = ultimonome(n1);	
	string y = ultimonome(n2);	
	bool z = x == y;
	return z;
}	
public string ultimonome (string nome)
{
    string buscar = nome.Substring(nome.LastIndexOf(" "));
    string espaco = buscar.Trim();
	return espaco;
}
bool familia = msm("jusicleito dos santos","marilene dos santos");
//mesma familia a partir do ultimo nome


public double TermoGeralPA (double primeiroTermo, double razao, double posicao)
{
	return primeiroTermo + (Conta2(posicao, razao));
	
}
public double Conta2 (double posicao, double razao) 
{
	return (posicao - 1) * razao;
}
// termo de PA


public double TermoGeralPG (double PrimeiroTermo, double razao, double posicaoDoTermo)
{
	double calculoRazao = Math.Pow(razao, CalculoPosicao(posicaoDoTermo));
	double calculoTotal = PrimeiroTermo * calculoRazao;
	return calculoTotal;
}
public double CalculoPosicao (double posicaoDoTermo)
{
	return posicaoDoTermo - 1;
}
// termo de PG
