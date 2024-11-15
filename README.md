
# Sistema de Hospedagem de Hotel

## Descrição
Este projeto é um sistema de reservas de hotel em C#, que permite gerenciar hóspedes, suítes e reservas. O sistema calcula automaticamente o valor da diária e aplica um desconto de 10% para reservas de longa duração (10 dias ou mais). Além disso, verifica se a capacidade da suíte atende ao número de hóspedes, lançando uma exceção quando essa regra é violada.

## Funcionalidades

- **Cadastro de Hóspedes**: Armazena informações sobre os hóspedes, como nome e sobrenome.
- **Cadastro de Suítes**: Permite cadastrar suítes com tipo, capacidade e valor da diária.
- **Reservas**: Permite realizar reservas, vinculando hóspedes a suítes e aplicando regras de capacidade.
- **Cálculo de Diária**: Calcula o valor total da diária, aplicando desconto de 10% para reservas de 10 dias ou mais.

## Tecnologias Utilizadas

- C#
- .NET Core (versão 6.0+)

## Estrutura do Projeto

O projeto é organizado nas seguintes classes:

- `Pessoa`: Representa um hóspede, contendo propriedades para o nome e sobrenome.
- `Suite`: Representa uma suíte de hotel com tipo, capacidade e valor da diária.
- `Reserva`: Realiza o vínculo entre hóspedes e suítes e implementa as regras de negócio.

## Regras de Negócio e Validações

1. **Capacidade da Suíte**: A reserva de uma suíte deve respeitar sua capacidade máxima. Se o número de hóspedes exceder a capacidade da suíte, o sistema lançará uma exceção.
2. **Quantidade de Hóspedes**: O método `ObterQuantidadeHospedes` da classe `Reserva` retorna o número total de hóspedes cadastrados.
3. **Cálculo do Valor da Diária**: O método `CalcularValorDiaria` multiplica o número de dias reservados pelo valor da diária da suíte. Se a reserva for de 10 dias ou mais, aplica um desconto de 10%.


