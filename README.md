# Teste-Dev-2021

Aplicação desenvolvida em .Net Core e Angular, pronta para rodar em banco de dados SqlServer (basta somente alterar a connectionString no arquivo appsettings.json)

Caso esteja com o erro

![Alt text](https://i.stack.imgur.com/gNMR2.png)

Diretivas para corrigir o erro da Aplicação, Abra o caminho Teste.Teste\ClientApp\node_modules\ngx-toastr

Na pasta toastr
  - no arquivo toast.component.d - <strong>comentar</strong> a linha 26 com o conteudo: get displayStyle(): string | undefined;
  - no arquivo toast-noanimation.component.d - <strong>comentar</strong> a linha 19 com o conteudo: get displayStyle(): string;

Na pasta portal
  - no arquivo portal.d - <strong>comentar</strong> a linha 26 com o conteudo: get isAttached(): boolean;
