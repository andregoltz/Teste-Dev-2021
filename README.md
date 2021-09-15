# Teste-Dev-2021

Aplicação desenvolvida em .Net Core e Angular, pronta para rodar em banco de dados SqlServer (basta somente alterar a connectionString no arquivo appsettings.json)

Caso esteja com o erro

![Alt text](https://www.google.com/url?sa=i&url=https%3A%2F%2Fstackoverflow.com%2Fquestions%2F34401822%2Fcannot-get-express-error&psig=AOvVaw1k1_jULVekPGGwk0K8Wk0c&ust=1631800883186000&source=images&cd=vfe&ved=0CAgQjRxqFwoTCMDfw5OSgfMCFQAAAAAdAAAAABAD)

Diretivas para corrigir o erro da Aplicação, Abra o caminho Teste.Teste\ClientApp\node_modules\ngx-toastr

Na pasta toastr
  - no arquivo toast.component.d - <strong>comentar</strong> a linha 26 com o conteudo: get displayStyle(): string | undefined;
  - no arquivo toast-noanimation.component.d - <strong>comentar</strong> a linha 19 com o conteudo: get displayStyle(): string;

Na pasta portal
  - no arquivo portal.d - <strong>comentar</strong> a linha 26 com o conteudo: get isAttached(): boolean;
