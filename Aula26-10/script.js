function validaNumero(id)
{
    let divNumero = document.getElementById(id)
    if(divNumero.value <= 0)
    {
        //alert('Número inválido')
        //console.log('Número inválido')
        divNumero.style.border = 'solid 1px red'
    }
    else
    {
        divNumero.style.border = 0;
    }
}

function validaPassword(id)
{
    let divPassword = document.getElementById(id)
    let senha = divPassword.value.trim()

    let temMinuscula = (/[a-z]/).test(senha)
    let temMaiuscula = (/[A-Z]/).test(senha)
    let temNumero = (/[0-9]/).test(senha)
    let temEspecial = (/[!@#$%¨&*(){}?:;.<>,|"'=-_]/).test(senha)
    let temOitoDigitos = senha.lenght >= 8

    //console.log(senha)
    //console.log('tem minuscula', temMinuscula)
    //console.log('tem maiuscula', temMaiuscula)
    //console.log('tem numero', temNumero)
    //console.log('tem caracter', temEspecial)
    //console.log('tem oito digitos', temOitoDigitos)

    if(temMinuscula && temMaiuscula && temNumero && temEspecial && temOitoDigitos)
    {
        divPassword.style.border = 0;
        return true
    }
    else
    {
        divPassword.style.border = 'solid 1px red'
        return false
    }
}

function cadastrar()
{
    let numeroValido = validaNumero('numero')
    let senhaValida = validaPassword('password')
    
    if(!numeroValido || !senhaValida)
    {
        alert('Corrija os dados em vermelho')
        return
    }

    alert('cadastro efetuado')

    //TODO montar json
    //TODO fazer post
}

function validaCep(id)
{
    let divCep = document.G=getElementById(id)
    fetch('https://viacep.com.br/ws/' + divCep.value + '/json').then(x=>x.json()).then(x=>document.getElementById('logradouro').value = x.logradouro)
    //document.getElementById('logradouro').value = logradouro
}