# Laboratório Simulado para Ensaios de Controle (LSEC)
[![NPM](https://img.shields.io/npm/l/react)](https://github.com/NicolasKamke/PlantSimulator/blob/main/LICENSE) 

# Sobre o projeto

A necessidade de simular processos e o efeito de controladores nos mesmos é conhecida e documentada, assim como a representação matemática de processos através de funções de transferências. 
Esse software foi costruído com o intuito de verificar a fidelidade de um software que simule a resposta de funções de transferências de primeira e segunda ordem, possibilitando ao usuário interação com a entrada e saída da mesma através de uma interface prática e intuitiva. 
O usuário também pode construir um controlador que se comunica com o software através do protocolo REST. Além de poder gerar documentos CSV's para verificar a fidelidade das saídas do software construído (LSEC) com outros softwares (MATLAB, Maple, etc). 

## Layout server
![Server](https://github.com/NicolasKamke/PlantSimulator/blob/main/assets/LayoutServer.jpeg) 

## Layout client
![Client](https://github.com/NicolasKamke/PlantSimulator/blob/main/assets/LayoutClient.jpeg)


## Modelo conceitual
![Modelo Conceitual](https://github.com/NicolasKamke/PlantSimulator/blob/main/assets/ModeloConceitual.jpeg)

# Tecnologias utilizadas
## Back end
- C#
## Front end
- WinForms

# Como executar o projeto

## Pré-requisitos
- Visual Studio 2019
- .NET Framework 4.7.2

## Importação dos certificados
![Importação de Certificado](https://github.com/NicolasKamke/PlantSimulator/blob/main/assets/ImportacaoCertificado.jpg)

Ambos os certificados se encontram em suas respectivas pastas "\PlantSimulator_Server" e "\PlantSimulator_Client"

- PlantSimulator_Server_TemporaryKey
- PlantSimulator_Client_TemporaryKey

# Autores

Hugo Cesar Da Silva Freitas
- www.linkedin.com/in/hugo-cesar-da-silva-freitas-7b7b04191/

Nícolas Kamke Schimidt
- www.linkedin.com/in/nschimidt


# Primeira Atualização do Laboratório Simulado para Ensaios de Controle (LSEC)

## Novas Funcionalidades
- Protocolo OPC UA (Planta - Servidor / Controlador - Cliente)
- Protocolo Protocolo Modbus TCP (Planta - Cliente)

## Novo Layout server
![Novo Layout Server](https://github.com/robsongrossferreira/PlantSimulator/blob/master/assets/NovoLayoutServer.jpg)

## Novo Layout client
![Novo Layout Client](https://github.com/robsongrossferreira/PlantSimulator/blob/master/assets/NovoLayoutClient.jpg)

## Fluxo De Dados - Opção 1
![Fluxo Dados 1](https://github.com/robsongrossferreira/PlantSimulator/blob/master/assets/FluxoDados1.jpg)

## Fluxo De Dados - Opção 2
![Fluxo Dados 2](https://github.com/robsongrossferreira/PlantSimulator/blob/master/assets/FluxoDados2.jpg)

# Autores Da Atualização (OPC UA + ModBus TCP)

João Paulo Ferreira


Robson Gross Ferreira
- www.linkedin.com/in/robson-gross-ferreira-7b2926a0
