using System;
//================//
public class info{
	public int inteira;
	public int meia;
	public double preco;
	public string filme;
}
		
public string calc (info a, info b, info c, info d){
	double ingmeia = (b.meia * c.preco)	/ 2;
	double ingint = a.inteira * c.preco;
	double total = ingmeia + ingint;
	int qtd = a.inteira + b.meia;
	return ("O valor da compra de " + qtd + " ingressos referente ao filme " + d.filme + " é R$" + total );
}

info a = new info();
	a.inteira = 2;
info b = new info();
	b.meia = 1;
info c = new info();
	c.preco = 25.00;
info d = new info();
	d.filme = "Transformes";

string calcular_valor_do_ingresso = calc(a, b, c, d);
//-----------------------------------------------------------------------------------------------------------------//
public class info2{
	public string jogador1;
	public string jogador2;
}

public bool jankepo(info2 p1, info2 p2){
	bool pe1 = p1.jogador1.Contains("Pedra") 	|| p1.jogador1.Contains("pedra");
	bool pa1 = p1.jogador1.Contains("Papel") 	|| p1.jogador1.Contains("papel");
	bool te1 = p1.jogador1.Contains("Tesoura") 	|| p1.jogador1.Contains("tesoura");
	
	bool pe2 = p2.jogador2.Contains("Pedra") 	|| p2.jogador2.Contains("pedra");
	bool pa2 = p2.jogador2.Contains("Papel") 	|| p2.jogador2.Contains("papel");
	bool te2 = p2.jogador2.Contains("Tesoura") 	|| p2.jogador2.Contains("tesoura");

	bool x = pe1 == true && pe2 == false && pa2 == false || pa1 == true && pa2 == false && te2 == false || te1 == true && pe2 == false && te2 == false;
	return x;
}

info2 p1 = new info2();
	p1.jogador1 = "tesoura";
info2 p2 = new info2();
	p2.jogador2 = "papel";

bool jokenpo = jankepo(p1, p2);
//-----------------------------------------------------------------------------------------------------------------//
public class estadia{
	public DateTime ida;
	public DateTime volta;
	public int pessoas;
}

public double dias (estadia a, estadia b){
	TimeSpan x = b.volta - a.ida;
	double z = x.TotalDays;
	return z + 1;
}

public double hotel(estadia a, estadia b, estadia c){
	double diaz = dias(a, b);
	double calc = (diaz * 120.00) * c.pessoas;
	double arre = Math.Round(calc,2);
	return arre;
}

estadia ida = new estadia();
	ida.ida = new DateTime(2021, 05 ,07);
estadia volta = new estadia();
DateTime x = new DateTime(2021,05,09);
	volta.volta = x;
estadia pessoas = new estadia();
	pessoas.pessoas = 4;

double HOTEL = hotel(ida, volta, pessoas);
//-----------------------------------------------------------------------------------------------------------------//
public class PassagemAerea
{
    public DateTime Ida;
    public DateTime Volta; 
    public int QtdAdultos; 
    public int QtdCriancas;
    public string Origem; 
    public string Destino; 
}


public double TotalDias2(DateTime ida, DateTime volta)
{
    TimeSpan dif = volta - ida;
    double dias = dif.TotalDays + 1;
    return dias;
}


public double CalcularPassagemAerea(PassagemAerea passagem)
{
    double dias = TotalDias2(passagem.Ida, passagem.Volta);
    double total = (dias * passagem.QtdAdultos * 200) + (dias * passagem.QtdCriancas * 100);
    return total;
}

PassagemAerea passagem = new PassagemAerea();
passagem.Ida = new DateTime(2021, 5, 7);
passagem.Volta = new DateTime(2021, 5, 9);
passagem.QtdAdultos = 2;
passagem.QtdCriancas = 2;
passagem.Origem = "São Paulo";
passagem.Destino = "New York";

double passagen = CalcularPassagemAerea(passagem);
//-----------------------------------------------------------------------------------------------------------------//
public class PassagemAerea2
{
	public DateTime ida;
	public DateTime volta;
	public int QtdAdultos;
	public int QtdCriancas;
	public string Origem;
	public string Destino;
}

public class EstadiaHotel
{
	public DateTime checkin;
	public DateTime checkout;
	public int qtdPessoas;
}

public class Comprovante
{
	public double total;
	public double TotalHotel;
	public double TotalPassagem;
	public string Mensagem;
}

public double TotalDias(DateTime Ida, DateTime Volta)
{
	TimeSpan dias = Volta - Ida;
	double dias2 = dias.Days + 1;
    return dias2;
}

public double HospedagemHotel(EstadiaHotel hotel)
{
	 double Estadia = (TotalDias(hotel.checkin, hotel.checkout)* 120) * hotel.qtdPessoas;
	 return Estadia;
}

public double Passagemaerea (PassagemAerea2 passagem)
{
	double Dias = TotalDias(passagem.ida, passagem.volta);
	double TotalGasto = ((passagem.QtdAdultos * 200) + (passagem.QtdCriancas * 200/2)) * Dias;
	return TotalGasto;
}

public Comprovante PacoteViagem (PassagemAerea2 passagem, EstadiaHotel hospedagem)
{	
	Comprovante comprovante = new Comprovante(); 
	comprovante.TotalHotel = HospedagemHotel(hospedagem);
	comprovante.TotalPassagem = Passagemaerea(passagem);
	comprovante.total = comprovante.TotalHotel + comprovante.TotalPassagem;
	return comprovante;
}

EstadiaHotel hospedagem = new EstadiaHotel();
	hospedagem.checkin = new DateTime (2021, 05, 07);
	hospedagem.checkout = new DateTime(2021, 05,09);
	hospedagem.qtdPessoas = 4;

PassagemAerea2 passagem2 = new PassagemAerea2();
	passagem2.ida = new DateTime (2021, 05, 07);
	passagem2.volta = new DateTime (2021, 05, 09);
	passagem2.QtdAdultos = 2;
	passagem2.QtdCriancas = 2;
	passagem2.Origem = "Brasil";
	passagem2.Destino = "França";

Comprovante Viagem = PacoteViagem(passagem2, hospedagem);
//-----------------------------------------------------------------------------------------------------------------//
Console.WriteLine("Ex1 = " + calcular_valor_do_ingresso);
Console.WriteLine("Ex2 = " + jokenpo);
Console.WriteLine("Ex3 = " + HOTEL);
Console.WriteLine("Ex4 = " + "O total da Viagem é : " + passagen);
Console.WriteLine("Ex5 = " + "A compra do Pacote de " + TotalDias(passagem2.ida, passagem2.volta) + " dia(s) para o destino " + passagem2.Destino + " foi finalizado com sucesso! O total incluindo todas despesas é de R$" + Viagem.total);