import{c as o,f as n,g as k,h as g,i as a}from"./chunk-THKE7DQS.js";var P=n(a(),1);var D=class D extends P.ColumnsBase{};o(D,"GenreColumns"),D.columnsKey="Default.Genre",D.Fields=(0,P.fieldsProxy)();var E=D;var v=n(a(),1);var p=class p{static getLookup(){return(0,v.getLookup)("Default.Genre")}static getLookupAsync(){return g(this,null,function*(){return(0,v.getLookupAsync)("Default.Genre")})}};o(p,"GenreRow"),p.idProperty="GenreId",p.nameProperty="Name",p.localTextPrefix="Default.Genre",p.lookupKey="Default.Genre",p.deletePermission="Administration:General",p.insertPermission="Administration:General",p.readPermission="Administration:General",p.updatePermission="Administration:General",p.Fields=(0,v.fieldsProxy)();var G=p;var A=n(a(),1),b;(e=>(e.baseUrl="Default/Genre",e.Methods={Create:"Default/Genre/Create",Update:"Default/Genre/Update",Delete:"Default/Genre/Delete",Retrieve:"Default/Genre/Retrieve",List:"Default/Genre/List"},["Create","Update","Delete","Retrieve","List"].forEach(t=>{e[t]=function(s,i,d){return(0,A.serviceRequest)(e.baseUrl+"/"+t,s,i,d)}})))(b||(b={}));var O=n(a(),1);var S,L,m=class{format(u){let e=u.value;if(!e||!e.length)return"";let t=S==null?void 0:S.itemById;return t?e.map(s=>{var i=t[s];return u.escape(i==null?s:i.Name)}).join(", "):(L!=null||(L=G.getLookupAsync().then(s=>{var i;S=s;try{(i=u.grid)==null||i.invalidate()}finally{S=null,L=null}}).catch(()=>L=null)),'<i class="fa fa-spinner"></i>')}};o(m,"GenreListFormatter"),m=k([O.Decorators.registerFormatter("MovieTutorial.GenreListFormatter")],m);var C=n(a(),1);var T=n(a(),1),M=(t=>(t[t.Film=1]="Film",t[t.TvSeries=2]="TvSeries",t[t.MiniSeries=3]="MiniSeries",t))(M||{});T.Decorators.registerEnumType(M,"Serene_Movies_Task.Default.MovieKind","MovieDB.MovieKind");var q=class q extends C.ColumnsBase{};o(q,"MovieColumns"),q.columnsKey="Default.Movie",q.Fields=(0,C.fieldsProxy)();var w=q;var U=n(a(),1);var l=class l{};o(l,"MovieRow"),l.idProperty="MovieId",l.nameProperty="Title",l.localTextPrefix="Default.Movie",l.deletePermission="Administration:General",l.insertPermission="Administration:General",l.readPermission="Administration:General",l.updatePermission="Administration:General",l.Fields=(0,U.fieldsProxy)();var I=l;var K=n(a(),1),h;(e=>(e.baseUrl="Default/Movie",e.Methods={Create:"Default/Movie/Create",Update:"Default/Movie/Update",Delete:"Default/Movie/Delete",Retrieve:"Default/Movie/Retrieve",List:"Default/Movie/List"},["Create","Update","Delete","Retrieve","List"].forEach(t=>{e[t]=function(s,i,d){return(0,K.serviceRequest)(e.baseUrl+"/"+t,s,i,d)}})))(h||(h={}));var y=n(a(),1);var R=class R extends y.PrefixedContext{constructor(u){if(super(u),!R.init){R.init=!0;var e=y.StringEditor;(0,y.initFormType)(R,["Name",e])}}};o(R,"GenreForm"),R.formKey="Default.Genre";var N=R;var r=n(a(),1);var f=class f extends r.PrefixedContext{constructor(u){if(super(u),!f.init){f.init=!0;var e=r.StringEditor,t=r.TextAreaEditor,s=r.IntegerEditor,i=r.DateEditor,d=r.LookupEditor,H=r.EnumEditor;(0,r.initFormType)(f,["Title",e,"Description",t,"Storyline",t,"Year",s,"ReleaseDate",i,"Runtime",s,"GenreList",d,"Kind",H])}}};o(f,"MovieForm"),f.formKey="Default.Movie";var F=f;var Y=n(a(),1);var c=class c{};o(c,"MovieGenresRow"),c.idProperty="MovieGenreId",c.localTextPrefix="Default.MovieGenres",c.deletePermission="Administration:General",c.insertPermission="Administration:General",c.readPermission="Administration:General",c.updatePermission="Administration:General",c.Fields=(0,Y.fieldsProxy)();var B=c;var z=n(a(),1),j;(e=>(e.baseUrl="Default/MovieGenres",e.Methods={Create:"Default/MovieGenres/Create",Update:"Default/MovieGenres/Update",Delete:"Default/MovieGenres/Delete",Retrieve:"Default/MovieGenres/Retrieve",List:"Default/MovieGenres/List"},["Create","Update","Delete","Retrieve","List"].forEach(t=>{e[t]=function(s,i,d){return(0,z.serviceRequest)(e.baseUrl+"/"+t,s,i,d)}})))(j||(j={}));export{E as a,N as b,G as c,b as d,w as e,F as f,I as g,h};
//# sourceMappingURL=chunk-VE5UAROC.js.map
