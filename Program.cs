//Declarando variáveis
string nome, categoria, resposta;
string faixaEtaria = "";
int idade;
float altura, peso, imc;
bool loop = true;

//Iniciando o loop
do
{
    // Criação do menu pedindo informações
    System.Console.WriteLine("-»«-»«-»«-»«-»«-»«-»«-»«-»«-»«-");
    System.Console.WriteLine("Seja bem-vindo a Calculadora de IMC da AP01 do Paulo!");
    System.Console.WriteLine("Por favor, insira seu nome:");
    nome = Console.ReadLine();
    System.Console.WriteLine($"Prazer {nome}!, agora me diga sua idade");
    idade = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Show! E a sua altura?");
    altura = float.Parse(Console.ReadLine());
    System.Console.WriteLine("E por último o seu peso em kg:");
    peso = float.Parse(Console.ReadLine());
    System.Console.WriteLine("-»«-»«-»«-»«-»«-»«-»«-»«-»«-»«-");

    // Conta do IMC
    imc = peso / (altura * altura);

    // Verificando em qual categoria a pessoa se encaixa de acordo com o cálculo do IMC
    if (imc <= 18.5)
    {
        categoria = "abaixo do peso";
    }
    else if (imc > 18.5 && imc <=24.9)
    {
        categoria = "no peso";
    }
    else if (imc > 24.9 && imc <= 29.9)
    {
        categoria = "em sobrepeso";
    }
    else
    {
        categoria = "obeso";
    }

    // Verificando a faixa etária de acordo com a variável idade
    if (idade >= 0 && idade <=12)
    {
        faixaEtaria = "criança";
    }
    else if (idade > 12 && idade <=18)
    {
        faixaEtaria = "adolescente";
    }
    else if (idade > 18 && idade <= 59)
    {
        faixaEtaria = "adulto";
    }
    else if (idade > 59)
    {
        faixaEtaria = "idoso";
    }

    // Imprimindo o relatório
    System.Console.WriteLine($"{nome} você tem {idade} anos, seu IMC é {imc}, " + $"és {faixaEtaria} e está {categoria}");

    // Confirmando repetição ou quebra do loop.
    System.Console.WriteLine("Deseja fazer emitir um novo relatório? S/N");
    resposta = Console.ReadLine().ToUpper();
    if (resposta == "N")
    {
        loop = false;
        System.Console.WriteLine("Muito obrigado por usar a calculadora! Espero nos vermos em breve.");
    }

}
while (loop == true);