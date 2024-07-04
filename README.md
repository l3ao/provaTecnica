# API de Gerenciamento de Clientes
Esta API fornece endpoints para listar, adicionar, editar e remover clientes cadastrados.

## Endpoints
### 1. Listar Clientes

Endpoint: `api/v1/clients`<br>
Método: _GET_<br>
Descrição: Retorna a lista de todos os clientes cadastrados.

**Resposta de Sucesso:**<br>_json:_
```
[
    {
        "id": 1,
        "nome": "João Silva",
        "email": "joao.silva@example.com"
    },
    {
        "id": 2,
        "nome": "Maria Souza",
        "email": "maria.souza@example.com"
    }
]
```

### 2. Adicionar Cliente
Endpoint: `api/v1/clients`<br>
Método: _POST_<br>
Descrição: Adiciona um novo cliente.

**Corpo da Requisição:**
```
{
    "nome": "Nome do Cliente",
    "email": "email@example.com"
}
```
**Resposta de Sucesso:**
```
{
    "id": 3,
    "nome": "Nome do Cliente",
    "email": "email@example.com"
}
```

## 3. Editar Cliente
Endpoint: `api/v1/clients/<id>`<br>
Método: _PUT_<br>
Descrição: Edita as informações de um cliente existente.

**Corpo da Requisição:**
```
{
    "nome": "Novo Nome do Cliente",
    "email": "novo.email@example.com"
}
```
**Resposta de Sucesso:**
```
{
    "id": 1,
    "nome": "Novo Nome do Cliente",
    "email": "novo.email@example.com"
}
```
### 4. Remover Cliente
Endpoint: `api/v1/clients/<id>`<br>
Método: _DELETE_<br>
Descrição: Remove um cliente existente.

**Resposta de Sucesso:**
```
{
    "mensagem": "Cliente removido com sucesso"
}
```
