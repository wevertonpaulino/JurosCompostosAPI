# Juros Compostos API

## API 1

### 1) Retorna taxa de juros

Responde pelo path relativo "/retornaTaxa".

Retorna o juros de 1% ou 0,01 (fixo no c�digo).

Exemplo: /retornaTaxa, resultado esperado: 0,01.

## API 2

### 1) Calcula Juros

Responde pelo path relativo "/calculaJuros".

Realiza um c�lculo em mem�ria, de juros compostos, conforme abaixo:

Valor Final = Valor Inicial * (1 + juros) ^ Tempo (^ representa a opera��o de pot�ncia).

Valor inicial � um decimal recebido como par�metro.

Valor do Juros deve ser consultado na API 1.

Tempo � um inteiro, que representa meses, tamb�m recebido como par�metro.

Resultado final deve ser truncado (sem arredondamento) em duas casas decimais.

Exemplo: /calculaJuros?valorInicial=100&meses=5, resultado esperado: 105,10.

### 2) Show me the code

Este responde pelo path relativo /showMeTheCode e dever� retornar a url de onde encontra-se o fonte no github.