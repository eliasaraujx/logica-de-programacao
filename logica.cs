//Prova de Lógica de Programação - Aluno: Elias Souza de Araujo

//Entrada de dados
//Processamento do cálculo
//Saída de informações
//Estrutura solicitada no algoritmo

//Nome, Total de Vendas, Salário e Comissão do Colaborador

//Entrada de dados
TextWindow.WriteLine("Digite o nome do Colaborador(a):")
Colaborador1=TextWindow.Read()
TextWindow.WriteLine("Digite o salário do Colaborador(a):")
SALARIO=TextWindow.Read()
TextWindow.WriteLine("Digite o total de vendas da primeira semana:")
PrimeiraSemana=TextWindow.Read()
TextWindow.WriteLine("Digite o total de vendas da segunda semana:")
SegundaSemana=TextWindow.Read()
TextWindow.WriteLine("Digite o total de vendas da terceira semana:")
TerceiraSemana=TextWindow.Read()
TextWindow.WriteLine("Digite o total de vendas da quarta semana:")
QuartaSemana=TextWindow.Read()

//Processamento de dados
TOTAL = PrimeiraSemana+SegundaSemana+TerceiraSemana+QuartaSemana

//Saída de dados
TextWindow.WriteLine("Nome do Colaborador: " + Colaborador1)
TextWindow.WriteLine("Total de vendas: R$ " + TOTAL)
TextWindow.WriteLine("Salário do mês: R$ " + SALARIO + " e Comissão de: ")

If TOTAL >= 5000 Then
  TextWindow.WriteLine("O Colaborador recebeu uma comissão de 10% sobre o total de vendas!")
Else
  TextWindow.WriteLine("O Colaborador não atingiu a meta mensal de vendas!")
EndIf

//Entrada de dados
TextWindow.WriteLine("Digite o nome do Colaborador(a):")
Colaborador2=TextWindow.Read()
TextWindow.WriteLine("Digite o salário do Colaborador(a):")
SALARIO = TextWindow.Read()
TextWindow.WriteLine("Digite o total de vendas da primeira semana:")
PrimeiraSemana=TextWindow.Read()
TextWindow.WriteLine("Digite o total de vendas da segunda semana:")
SegundaSemana=TextWindow.Read()
TextWindow.WriteLine("Digite o total de vendas da terceira semana:")
TerceiraSemana=TextWindow.Read()
TextWindow.WriteLine("Digite o total de vendas da quarta semana:")
QuartaSemana=TextWindow.Read()

//Processamento de dados
TOTAL = PrimeiraSemana+SegundaSemana+TerceiraSemana+QuartaSemana

//Saída de dados
TextWindow.WriteLine("Nome do Colaborador: " + Colaborador2)
TextWindow.WriteLine("Total de vendas: R$ " + TOTAL)
TextWindow.WriteLine("Salário do mês: R$ " + SALARIO)

If TOTAL >= 5000 Then
  TextWindow.WriteLine("O Colaborador recebeu uma comissão de 10% sobre o total de vendas!")
Else
  TextWindow.WriteLine("O Colaborador não atingiu a meta mensal de vendas!")
  EndIf
 
//Entrada de dados
TextWindow.WriteLine("Digite o nome do Colaborador(a):")
Colaborador3= TextWindow.Read()
TextWindow.WriteLine("Digite o salário do Colaborador(a):")
SALARIO=TextWindow.Read()
TextWindow.WriteLine("Digite o total de vendas da primeira semana:")
PrimeiraSemana=TextWindow.Read()
TextWindow.WriteLine("Digite o total de vendas da segunda semana:")
SegundaSemana=TextWindow.Read()
TextWindow.WriteLine("Digite o total de vendas da terceira semana:")
TerceiraSemana=TextWindow.Read()
TextWindow.WriteLine("Digite o total de vendas da quarta semana:")
QuartaSemana=TextWindow.Read()

//Processamento de dados
TOTAL = PrimeiraSemana+SegundaSemana+TerceiraSemana+QuartaSemana

//Saída de dados
TextWindow.WriteLine("Nome do Colaborador: " + Colaborador3)
TextWindow.WriteLine("Total de vendas: R$ " + TOTAL)
TextWindow.WriteLine("Salário do mês: R$ " + SALARIO)

If TOTAL >= 5000 Then
  TextWindow.WriteLine("O Colaborador recebeu uma comissão de 10% sobre o total de vendas!")
Else
  TextWindow.WriteLine("O Colaborador não atingiu a meta mensal de vendas!")
  EndIf

//Entrada de dados
TextWindow.WriteLine("Digite o nome do Colaborador(a):")
Colaborador4= TextWindow.Read()
TextWindow.WriteLine("Digite o salário do Colaborador(a):")
SALARIO=TextWindow.Read()
TextWindow.WriteLine("Digite o total de vendas da primeira semana:")
PrimeiraSemana=TextWindow.Read()
TextWindow.WriteLine("Digite o total de vendas da segunda semana:")
SegundaSemana=TextWindow.Read()
TextWindow.WriteLine("Digite o total de vendas da terceira semana:")
TerceiraSemana=TextWindow.Read()
TextWindow.WriteLine("Digite o Total de Vendas da Quarta Semana:")
QuartaSemana=TextWindow.Read()

//Processamento de dados
TOTAL = PrimeiraSemana+SegundaSemana+TerceiraSemana+QuartaSemana

//Saída de dados
TextWindow.WriteLine("Nome do Colaborador: " + Colaborador4)
TextWindow.WriteLine("Total de vendas: R$ " + TOTAL)
TextWindow.WriteLine("Salário do mês: R$ " + SALARIO)

If TOTAL >= 5000 Then
  TextWindow.WriteLine("O Colaborador recebeu uma comissão de 10% sobre o total de vendas!")
Else
  TextWindow.WriteLine("O Colaborador não atingiu a meta mensal de vendas!")
EndIf

//Fim do programa