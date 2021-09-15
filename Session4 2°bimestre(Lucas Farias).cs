using System;
//====================================================================

public string Retangulos(double B1, double A1, double B2, double A2)
{
	return (B1 * A1) == (B2 * A2) ?"Os retângulos são iguais" :"Os retânglos são diferentes";
}

string RetangulosIguais = Retangulos(3, 4, 6, 2);

//====================================================================

public double AreaRetangulos(double Base, double Altura)
{
	return Base * Altura;
}

public string Retangulos2(double B1, double A1, double B2, double A2)
{
	if(AreaRetangulos(B1, A1) == AreaRetangulos(A2, B2))
	{
		return "Os retângulos são iguais";
	}
	else if(AreaRetangulos(A1, B1) > AreaRetangulos(A2, B2))
	{
		return "O primeiro retângulo é maior";
	}
	else
	{
		return "O segundo retangulo é maior";
	}
}

string RetanguloMaior = Retangulos2(3, 4, 4, 5);

//====================================================================

public class MedidasRetangulos
{
	public double Altura 	{get; set;}
	public double Basee		{get; set;}
}

public string Retangulos3(MedidasRetangulos ret1, MedidasRetangulos ret2, MedidasRetangulos ret3)
{
	if(AreaRetangulos(ret1.Basee, ret1.Altura) == AreaRetangulos(ret2.Basee, ret2.Altura) && AreaRetangulos(ret1.Basee, ret1.Altura) == AreaRetangulos(ret3.Basee, ret3.Altura))
	{
		return "Os retangulos são iguais";
	}
	
	else if(AreaRetangulos(ret1.Basee, ret1.Altura) >= AreaRetangulos(ret2.Basee, ret2.Altura) && AreaRetangulos(ret1.Basee, ret1.Altura) >= AreaRetangulos(ret3.Basee, ret3.Altura))
	{
		return "O 1° retângulo é maior";
	}
	
	else if(AreaRetangulos(ret2.Basee, ret2.Altura) >= AreaRetangulos(ret1.Basee, ret1.Altura) && AreaRetangulos(ret2.Basee, ret2.Altura) >= AreaRetangulos(ret3.Basee, ret3.Altura))
	{
		return "O 2° retângulo é maior";
	}
	
	else
	{
		return "O 3° retângulo é maior";
	}
}

MedidasRetangulos Retangulo1 = new MedidasRetangulos();
	Retangulo1.Altura = 0;
	Retangulo1.Basee = 10;

MedidasRetangulos Retangulo2 = new MedidasRetangulos();
	Retangulo2.Altura = 2;
	Retangulo2.Basee = 10;

MedidasRetangulos Retangulo3 = new MedidasRetangulos();
	Retangulo3.Altura = 2;
	Retangulo3.Basee = 10;

string OsTresRetangulos = Retangulos3(Retangulo1, Retangulo2, Retangulo3);

//====================================================================

public class Ingresso
{
	public bool 	Meia 	{get; set;}
	public double 	Preco	{get; set;}
	public string 	Filme	{get; set;}
}

public class Cinemark
{
	public double CalcularTotal1(Ingresso ing)
	{
		return ing.Meia == true ?ing.Preco/2 :ing.Preco;
	}
	
	public string CalcularTotal2(Ingresso ing)
	{
		return ing.Meia == true ?($"Compra Concluida! O ingresso para o filme {ing.Filme} é de R${ing.Preco / 2}") :($"Compra Concluida! O ingresso para o filme {ing.Filme} é de R${ing.Preco}");
	}
	public double CalcularTotal3(Ingresso ing1, Ingresso ing2)
	{
		return (ing1.Meia == true ?ing1.Preco/2 :ing1.Preco) + (ing2.Meia == true ?ing2.Preco/2 :ing2.Preco);
	}
}

Cinemark cinemark = new Cinemark();
Ingresso ing  	  = new Ingresso();
	ing.Filme 	  = "Deu a louca na chapeuzinho";
	ing.Meia	  = true;
	ing.Preco	  = 30.00;
Ingresso ing2  	  = new Ingresso();
	ing2.Filme 	  = "Brightburn - Filho das Trevas";
	ing2.Meia	  = false;
	ing2.Preco	  = 50.00;

double cinema1 = cinemark.CalcularTotal1(ing);
string cinema2 = cinemark.CalcularTotal2(ing2);
double cinema3 = cinemark.CalcularTotal3(ing, ing2);

//====================================================================

public class Ingressos2
{
	public int		QtdIngressos	{get; set;}
	public bool 	   BtMeia		{get; set;}
	public double 	   VlPreco		{get; set;}
	public string	   NmFilme		{get; set;}
}

public class cinemark2
{

	public double Total1(Ingressos2 ing)
	{
		return 	ing.BtMeia == true 
				?(ing.VlPreco / 2)*ing.QtdIngressos
				: ing.VlPreco * ing.QtdIngressos;
	}
	
	public string Total2(Ingressos2 ing)
	{
		if(ing.BtMeia == true)
		{
			return $"Compra concluída! A compra de {ing.QtdIngressos} ingressos Meia para o filme {ing.NmFilme} é de R${ing.VlPreco * ing.QtdIngressos / 2}";
		}
		
		else
		{
			return $"Compra concluída! A compra de {ing.QtdIngressos} ingressos Inteira para o filme {ing.NmFilme} é de R${ing.VlPreco * ing.QtdIngressos}";
		}
	}

}

cinemark2 Cinemark2 	= new cinemark2();
Ingressos2 ing3 		= new Ingressos2();
	ing3.NmFilme		= "Caça Fantasmas";
	ing3.VlPreco		= 45.00;
	ing3.QtdIngressos	= 2;
	ing3.BtMeia			= false;

double cinema4 = Cinemark2.Total1(ing3);
string cinema5 = Cinemark2.Total2(ing3);

//====================================================================

public class Ingressos3
{
	public	int		QtdIngresso	{get; set;}
	public	bool 	BtMeia		{get; set;}
	public	double 	VlPreco		{get; set;}
	public 	string	NmFilme		{get; set;}
}

public class cinemark3
{
	
	public double Total(Ingressos3 ing, double cupom)
	{	
		return AplicarCupom(ing.BtMeia == true ?(ing.QtdIngresso * ing.VlPreco)/2 :ing.QtdIngresso * ing.VlPreco, cupom);
	}
	
	private double AplicarCupom(double total, double cupom)
	{
		return total - (total * cupom / 100);
	}
	
}

cinemark3 Cinemark3 	= new cinemark3();
Ingressos3 ing4 		= new Ingressos3();
	ing4.BtMeia			= true;
	ing4.VlPreco		= 45.00;
	ing4.NmFilme		= "Barbie e o Mundo Encantado";
	ing4.QtdIngresso	= 3;

double cinema6 = Cinemark3.Total(ing4, 5);

//====================================================================

public class Ingressos4
{
	public	int		QtdIngresso	{get; set;}
	public	bool 	BtMeia		{get; set;}
	public	double 	VlPreco		{get; set;}
	public 	string	NmFilme		{get; set;}
}

public class cinemark4
{
	
	public double Total(Ingressos4 ing, double cupom)
	{	
		double checar =	ing.BtMeia == true 
						?(ing.QtdIngresso * ing.VlPreco)/2 
						:ing.QtdIngresso * ing.VlPreco;
		
		double desconto = AplicarCupom(checar, cupom);
		
		double checar2 = desconto > 100
					  	 ? AplicarCupom(desconto, 10)
						 : desconto;
		return checar2;
	}
	
	private double AplicarCupom(double total, double cupom)
		
	{
		return total - (total * cupom / 100);
	}
	
}

cinemark4 Cinemark4 = new cinemark4();

Ingressos4 ing5  = new Ingressos4();
ing5.BtMeia 	 = true;
ing5.NmFilme	 = "gnomeu e julieta";
ing5.QtdIngresso = 2;
ing5.VlPreco 	 = 20.00;

double cinema7 = Cinemark4.Total(ing5, 2);

//====================================================================

public class Ingressos5
{
	public	int		QtdIngresso	{get; set;}
	public	bool 	BtMeia		{get; set;}
	public	double 	VlPreco		{get; set;}
	public 	string	NmFilme		{get; set;}
}

public class cinemark5
{
	
	public double Total(Ingressos5 ing, double cupom)
	{	
		double checar =	ing.BtMeia == true 
						?(ing.QtdIngresso * ing.VlPreco)/2 
						:ing.QtdIngresso * ing.VlPreco;
		
		double desconto = AplicarCupom(checar, cupom);
		
		double checar2 = (int)DateTime.Now.DayOfWeek == 3
		  			  	 ? AplicarCupom(desconto, 50)
						 : desconto;
		
		double checar3 = checar2 > 100
					  	 ? AplicarCupom(desconto, 10)
						 : desconto;
		return checar3;
	}
	
	private double AplicarCupom(double total, double cupom)
		
	{
		return total - (total * cupom / 100);
	}
	
}

cinemark5 Cinemark5 = new cinemark5();

Ingressos5 ing6  = new Ingressos5();
	ing6.BtMeia 	 = true;
	ing6.NmFilme	 = "gnomeu e julieta";
	ing6.QtdIngresso = 2;
	ing6.VlPreco 	 = 20.00;

double cinema8 = Cinemark5.Total(ing6, 2);

//====================================================================

public class Ingressos6
{
	public	int		QtdIngresso	{get; set;}
	public	bool 	BtMeia		{get; set;}
	public	double 	VlPreco		{get; set;}
	public 	string	NmFilme		{get; set;}
	public	string	DsGenero	{get; set;}
}

public class cinemark6
{

	public double Total (Ingressos6 ing, double cupom)
	{
		if(ing.DsGenero.ToUpper() == "NACIONAL")
		{
			double meia  = ing.BtMeia == true
							? (ing.QtdIngresso * 5) / 2
							:  ing.QtdIngresso * 5;
			
			return AplicarCupom(meia, cupom);
		}
		else
		{
			double meia  = ing.BtMeia == true
							? (ing.QtdIngresso * 5) / 2
							:  ing.QtdIngresso * 5;
			
			double desconto = AplicarCupom(meia, cupom);
		
			double checar2 = (int)DateTime.Now.DayOfWeek == 3
							 ? AplicarCupom(desconto, 50)
							 : desconto;

			double checar3 = checar2 > 100
							 ? AplicarCupom(desconto, 10)
							 : desconto;
			return checar3;
		}
		
	}
	
	private double AplicarCupom(double total, double cupom)
	{
		return total - (total * cupom / 100);
	}
	
}
cinemark6 Cinemark6  = new cinemark6();

Ingressos6 ing7 	 = new Ingressos6();
	ing7.BtMeia 	 = true;
	ing7.NmFilme	 = "gnomeu e julieta";
	ing7.QtdIngresso = 2;
	ing7.VlPreco 	 = 20.00;
	ing7.DsGenero 	 = "Romance";

double cinema9 = Cinemark6.Total(ing7, 0);

//====================================================================

public class Jogador
{
	public string	Nome 	{get; set;}
	public int		Numero	{get; set;}
	public bool		Par 	{get; set;}
}

public string jogoPar(Jogador p1, Jogador p2)
{
	int soma = p1.Numero + p2.Numero;
	string Vencedor = "";
	if(soma % 2 == 0 && p1.Par == true)
	{
		 Vencedor = $"Par! o {p1.Nome} venceu.";
	}
	else if(soma % 2 == 1 && p1.Par == false)
	{
		 Vencedor = $"Ímpar! o {p1.Nome} venceu.";
	}
	else if(soma % 2 == 0 && p2.Par == true)
	{
		 Vencedor = $"Par! o {p2.Nome} venceu.";
	}
	else if(soma % 2 == 1 && p2.Par == false)
	{
		Vencedor = $"Ímpar! o {p2.Nome} venceu.";
	}
	return Vencedor;
}

Jogador Player1	 	= new Jogador();
	Player1.Nome 	= "Lucas";
	Player1.Numero	= 4;
	Player1.Par 	= true;

Jogador Player2	 	= new Jogador();
	Player2.Nome 	= "Skal";
	Player2.Numero	= 6;
	Player2.Par 	= false;

string P_ou_Í = jogoPar(Player1, Player2);

//====================================================================
				
public class jogadas{
	public bool 	pedra	{get; set;}
	public bool 	papel 	{get; set;}
	public bool 	tesoura	{get; set;}
	public string 	nome 	{get; set;}
}

public string jakenpo(jogadas p1, jogadas p2)
{
	string fim = "";
	if(p1.pedra == true && p2.tesoura == true || p1.papel == true && p2.pedra == true || p1.tesoura == true && p2.papel == true)
	{
		fim = $"{p1.nome} venceu";
	}

	else if(p2.pedra == true && p1.tesoura == true || p2.papel == true && p1.pedra == true || p2.tesoura == true && p1.papel == true)
	{
		fim = $"{p2.nome} venceu";
	}
	
	else if (p2.pedra == true && p1.pedra == true || p2.papel == true && p1.papel == true || p2.tesoura == true && p1.tesoura == true)
	{
		fim = "Deu empate";
	}
	
	else
	{
		fim = "Tem que jogar aluma coisa amigo";
	}
	return fim;
}

jogadas j1 = new jogadas();
	j1.pedra	= false;
	j1.papel 	= false;
	j1.tesoura 	= true;
	j1.nome		="Apolo";

jogadas j2 = new jogadas();
	j2.pedra 	= false;
	j2.papel 	= true;
	j2.tesoura 	= false;
	j2.nome		="Skal";

string Jokenpo = jakenpo(j1, j2);

//====================================================================
//					Cosonles WriteLines
Console.WriteLine("--------EXERCÍCIO 01--------");
Console.WriteLine($"RetangulosIguais = {RetangulosIguais}");
Console.WriteLine();
//
Console.WriteLine("--------EXERCÍCIO 02--------");
Console.WriteLine($"MaiorRetangulo = {RetanguloMaior}");
Console.WriteLine();
//
Console.WriteLine("--------EXERCÍCIO 03--------");
Console.WriteLine($"MaiorRetangulo2 = {OsTresRetangulos}");
Console.WriteLine();
//
Console.WriteLine("--------EXERCÍCIO 04--------");
Console.WriteLine($"Cinemark1 = {cinema1}");
Console.WriteLine($"Cinemark2 = {cinema2}");
Console.WriteLine($"Cinemark3 = {cinema3}");
Console.WriteLine();
//
Console.WriteLine("--------EXERCÍCIO 05--------");
Console.WriteLine($"Cinemark4 = {cinema4}");
Console.WriteLine($"Cinemark5 = {cinema5}");
Console.WriteLine();
//
Console.WriteLine("--------EXERCÍCIO 06--------");
Console.WriteLine($"Cinemark6 = {cinema6}");
Console.WriteLine();
//
Console.WriteLine("--------EXERCÍCIO 07--------");
Console.WriteLine($"Cinemark7 = {cinema7}");
Console.WriteLine();
//
Console.WriteLine("--------EXERCÍCIO 08--------");
Console.WriteLine($"Cinemark8 = {cinema8}");
Console.WriteLine();
//
Console.WriteLine("--------EXERCÍCIO 09--------");
Console.WriteLine($"Cinemark9 = {cinema9}");
Console.WriteLine();
//
Console.WriteLine("--------EXERCÍCIO 10--------");
Console.WriteLine($"Jokenpo = {Jokenpo}");
Console.WriteLine();
//
Console.WriteLine("--------EXERCÍCIO 11--------");
Console.WriteLine($"Par ou Ímpar = {P_ou_Í}");