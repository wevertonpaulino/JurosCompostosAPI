# Juros Compostos API

## API 1

### 1) Retorna taxa de juros

Responde pelo path relativo "/api/RetornaTaxa".

Retorna o juros de 1% ou 0,01 (fixo no código).

Exemplo: /api/RetornaTaxa, resultado esperado: 0,01.

## API 2

### 1) Calcula Juros

Responde pelo path relativo "/api/CalculaJuros".

Realiza um cálculo em memória, de juros compostos, conforme abaixo:

Valor Final = Valor Inicial * (1 + juros) ^ Tempo (^ representa a operação de potência).

Valor inicial é um decimal recebido como parâmetro.

Valor do Juros deve ser consultado na API 1.

Tempo é um inteiro, que representa meses, também recebido como parâmetro.

Resultado final deve ser truncado (sem arredondamento) em duas casas decimais.

Exemplo: /api/CalculaJuros?valorInicial=100&meses=5, resultado esperado: 105,10.

### 2) Show me the code

Este responde pelo path relativo /api/ShowMeTheCode e deverá retornar a url de onde encontra-se o fonte no github.