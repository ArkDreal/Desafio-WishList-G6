import React from 'react';

export default class DesejosEUsuarios extends React.Component{
  
  constructor(props) {
    super(props);
    this.state = {
      listaDesejos : [],
      titulo : ''
    };
};
  
componentDidMount() {
  this.buscarDesejo();
}



cadastrarTipoDesejo = (event) => {
  // Ignora o comportamento padrão do navegador
  event.preventDefault();

  
      // Segue para o processo de atualização

      // http://localhost:5000/api/tiposeventos/4
      fetch('http://localhost:5000/api/Desejo', {
          method : 'POST',
          body : JSON.stringify({ descricao : this.state.titulo, idUsuario: 1 }),
          headers : {
              "Content-type" : "application/json"
          }
      })

      .then(resposta => {
          if (resposta.status === 204) {
              console.log(
                  'O Tipo de Evento ' + this.state.idTipoEventoAlterado + ' foi atualizado!',
                  'Seu novo título agora é :' + this.state.titulo
              )
          }
      })

      // caso ocorra algum erro, mostra no console do navegador
      .catch(erro => console.log(erro))

      .then(console.log("Desejo cadastrado."))

      
  

        
}
  

    atualizaStateDesejo = async (desejo) => {
        await this.setState({titulo : desejo.target.value})
        console.log(this.state.titulo)
    }

    buscarDesejo = () => {
        fetch('http://localhost:5000/api/Desejo')
        
        .then( resposta => resposta.json())

        .then( dados => this.setState({listaDesejos : dados}))

        .catch(error => console.log(error))
    }


    render(){
        return(
            <div>
                <main>
                    <section>
                        <h2>Lista de desejos</h2>
                        <table>
                            <thead>
                              <tr>
                                <th>Titulo</th>
                                <th>Nome</th>
                                <th>Desejos</th>
                              </tr>
                            </thead>
                            <tbody id="tabela-lista-corpo">
                                    {
                                        this.state.listaDesejos.map((Desejos => {
                                            console.log(Desejos)
                                          return (
                                                <tr key={Desejos.idDesejo}>
                                                    <td>{Desejos.idUsuarioNavigation.Nome}</td>
                                                    <td>{Desejos.descricao}</td>                                       
                                                </tr>
                                            )
                                        }))
                                      }
                                </tbody>
                        </table>
                    </section>
                    
                    <section>
                        <h2>Cadastre um desejo</h2>
                        <form onSubmit = {this.cadastrarTipoDesejo}>
                            <div>
                                <input type = "text"
                                value = {this.titulo}
                                placeholder = "Titulo do desejo"
                                onChange = {this.atualizaStateDesejo} />

                                <button type = "submit"> Cadastrar </button>
                            </div>

                        </form>
                    </section>
                </main>
            </div>
            
        )
    }
}
