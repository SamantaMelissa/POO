using ControleClientes;

Console.WriteLine($"Informe seu nome:");
string variavelNome = Console.ReadLine();
Console.WriteLine($"Informe seu Endereço:");
string variavelEndereco = Console.ReadLine();
Console.WriteLine($"Informe se é pessoa física(f) ou pessoa jurídica(j):");
string varivaelTipo = Console.ReadLine();

//Validar se é F ou J
//Retornar o resultado do calculo
if(varivaelTipo == "f"){
    //Instanciar uma classe:
    //Peguei a classe(modelo) e criei algo real, que seria o objeto chamado pj
    Pessoa_Fisica pf = new Pessoa_Fisica();
    //Atribuir valores para o meu objeto:
    pf.nome = variavelNome;
    pf.endereco = variavelEndereco;

    Console.WriteLine($"Informe o CPF:");
    pf.cpf = Console.ReadLine();

    Console.WriteLine($"Informe o RG:");
    pf.rg = Console.ReadLine();

    Console.WriteLine($"Informe o valor da compra:");
    float valorCompra = float.Parse(Console.ReadLine());

    pf.Pagar_Imposto(valorCompra);

    Console.WriteLine("-------- Pessoa Física ---------");
    Console.WriteLine("Nome ..........: " + pf.nome);
    Console.WriteLine("Endereço ......: " + pf.endereco);
    Console.WriteLine("CPF ...........: " + pf.cpf);
    Console.WriteLine("RG ............: " + pf.rg);
    Console.WriteLine("Valor de Compra: " + valorCompra);
    Console.WriteLine("Imposto .......: " + pf.valor_imposto.ToString("C"));
    Console.WriteLine("Total a Pagar :  "  + pf.total.ToString("C"));

}else if(varivaelTipo == "j"){
    Pessoa_Juridica pj = new Pessoa_Juridica();

    pj.nome = variavelNome;
    pj.endereco = variavelEndereco;

    Console.WriteLine($"Informe seu CNPJ:");
    pj.cnpj = Console.ReadLine();
    
    Console.WriteLine($"Informe seu IE:");
    pj.ie = Console.ReadLine();

    Console.WriteLine($"Informe o valor da compra:");
    float valorCompra = float.Parse(Console.ReadLine());

    pj.Pagar_Imposto(valorCompra);

    Console.WriteLine("-------- Pessoa Jurídica ---------");
    Console.WriteLine("Nome ..........: " + pj.nome);
    Console.WriteLine("Endereço ......: " + pj.endereco);
    Console.WriteLine("CNPJ ..........: " + pj.cnpj);
    Console.WriteLine("IE ............: " + pj.ie);
    Console.WriteLine("Valor de Compra: " + pj.valor.ToString("C"));
    Console.WriteLine("Imposto .......: " + pj.valor_imposto.ToString("C"));
    Console.WriteLine("Total a Pagar :  " + pj.total.ToString("C"));

}else{
    Console.WriteLine($"Informação inválida!");
}


//Herança e polimorfismo - ok
//abstração e o encapsulamento 


