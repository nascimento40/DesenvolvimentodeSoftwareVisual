
function cadastrar()
{
	if(!validaNome('nome'))
	{
        alert ("Nome não informado")
        console.log(alert)
		return
	}
	if(!validaData('nascimento'))
	{
        alert ("Data não informada")
        console.log(alert)
		return
	}
    /*if(!validaGenero('genero'))
	{
        alert("Gênero não infomado")
        console.log(alert)
		return
	}*/

		/*
			INSTRUCOES
					
			primeiramente voce deve:
					
			(0.1) verificar se foi informado pelo menos um nome e um sobrenome
			(0.1) verificar se foi selecionada uma data
			(0.1) verificar se foi selecionado um genero
					
			caso algum campo nao tenha sido preenchido
					
			(0.3) exibir um alerta informando todos os campos que nao foram preenchidos e interromper cadastro
					
			caso contrario, exibir um alerta com um texto de boas vindas. o texto deve:
					
			(0.2) usar a flexao de genero apropriada (a/o/e)
			(0.2) mencionar apenas o primeiro nome da pessoa
			(0.5) informar a idade da pessoa
			(0.5) informar o numero de consoantes que o nome completo dela possui
					   
			    por exemplo
                se os dados forem "Luiz da Silva", "masculino" e "1945-10-27"
			    o texto deve ser "Bem vindo, Luiz! Você tem 77 anos e seu nome completo possui 6 consoantes."
					
			    em seguida voce deve inserir na div "resposta" os seguintes elementos:
					
			(1.4) um heading contendo o nome do ultimo feriado ocorrido
			      o nome do feriado deve ser extraido do json retornado atraves de um get em https://date.nager.at/api/v3/PublicHolidays/2022/BR
			      a data de referencia deve ser o dia em que o usuario esta acessando o site
					      
			(0.2) abaixo do heading, uma image do animal do dia
			      a url da imagem deve ser extraida do json retornado atraves de um get em https://zoo-animal-api.herokuapp.com/animals/rand
					
			(0.4) abaixo da image, um span contendo uma frase motivacional
			      a frase deve ser extraida do json retornado atraves de um get em https://api.adviceslip.com/advice
			      a frase deve ser colocada em estilo italico
		*/
}

		//function validaNome(id)
		//{
		//	let divNome = document.getElementById(id)
		//    if(divNome.value.trim().split(' ').length >= 2)
		//{
		//	divNome.style.border = 1
		//	return true
		//}
		//	else
		//{
		//	divNome.style.border = 'solid 1px red'
		//	return false
		//}
		//}

    function validaNome(id)
{
	let divNome = document.getElementById(id)
	if(divNome.value.trim().split(' ').length >= 2)
	{
		divNome.style.border = 0
		divNome.classList.remove('erro-input')
		return true
	}
	else
	{
		divNome.style.border = 'solid 1px red'
		if(!divNome.classList.contains('erro-input'))
		{
			divNome.classList.add('erro-input')
		}
		return false
	}
}

	function validaData(id)
	{
		let divData = document.getElementById(id)
		if(divData.value.length > 0)
		{
			divData.style.border = 0
			return true
		}
		else
		{
			divData.style.border = 'solid 1px red'
			return false
		}
	}

    /*function genero()
{
	//da um GET no endpoint "generos"
	fetch(url + 'generos')
	.then(response => response.json())
	.then((Generos) =>
	{
		//PEGA OPTION VAZIA NO HTML
		let selUsuarios = document.getElementById('genero')
				
		//PREENCHE ELA COM O NOME E O ID DOS USUARIOS
		for(let Genero of Generos)
		{
			let optUsuario = document.createElement('option')
			optUsuario.innerHTML = Genero.nome
			optUsuario.value = Genero.id
			selUsuarios.appendChild(optUsuario)
		}
	})
}*/

function validaGenero(id) {
    let genero = document.getElementById(id) 
    console.log(genero.value)
    if (genero.value === "genero") {
        return false
    }
}

/*function alerta(id, divNome, divData, divGenero) {
    'nome': divNome.value,
    'nascimento': divData.value,
    'genero': divGenero.value
}*/
		
    