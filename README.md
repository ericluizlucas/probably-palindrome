Observe as seguintes strings:

"parar"
"temem"
"technation"

"parar" e "temem" são chamadas de palavras potencialmente palíndromas.

Isso ocorre porque você pode rearranjar/permutar as letras dessas palavras de forma que elas se tornem palíndromas.

"parar" => "rapar"
"temem" => "metem"

Enquanto isso "technation" nunca será uma palavra palíndroma, independentemente de como você reorganizar as letras dela.

Observações adicionais:

1) Não é necessário que as strings sejam palavras que existem na vida real.

2) Considere a string vazia como potencialmente palíndroma.

# Descrição da função solução:

1) Recebe como parâmetro uma string.
2) Retorna True, caso a palavra seja potencialmente palíndroma. Retorna False, caso contrário.

# Exemplos:

Entrada = "abbac"
Saída = True

Entrada= "abba"
Saída = True

Entrada= "abbacd"
Saída= False