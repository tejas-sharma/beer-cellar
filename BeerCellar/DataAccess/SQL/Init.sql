use beercellar

create table users
( 
    id int identity constraint PK_users PRIMARY KEY CLUSTERED not null,
    first_name nvarchar(50) not null,
    last_name nvarchar(50) not null,
    dob date not null
)

create table roles
( 
    id int identity constraint PK_roles PRIMARY KEY CLUSTERED not null,
    role_name nvarchar(50) not null,
    role_description nvarchar(max) null
)

create table users_roles 
(
    user_id int not null,
    role_id int not null
)

alter table users_roles
add constraint PK_users_roles 
PRIMARY KEY NONCLUSTERED (user_id, role_id)

alter table users_roles
add constraint FK_users_roles_users FOREIGN KEY (user_id) references users (id) on delete cascade

alter table users_roles
add constraint FK_users_roles_roles FOREIGN KEY (role_id) references roles (id) on delete cascade

create nonclustered index ix_users_roles_user_id
on users_roles (user_id)

create nonclustered index ix_users_roles_role_id
on users_roles (role_id)

create table beer_cellars
(
    id int identity constraint PK_beer_cellars PRIMARY KEY CLUSTERED not null,
    owner int constraint FK_beer_cellars_users references users (id) on delete cascade,
    name nvarchar(250) not null
)

create nonclustered index ix_beer_cellars_owner
on beer_cellars (owner)

create table brewers
(
    id int identity constraint PK_brewers PRIMARY KEY CLUSTERED not null,
    name nvarchar(250) not null
)

create table beers
(
    id int identity constraint PK_beers PRIMARY KEY CLUSTERED not null,
    brewer_id int constraint FK_beers_brewers references brewers (id) on delete cascade,
    name nvarchar(250) not null 
)

create nonclustered index ix_beers_brewer_id
on beers (brewer_id)


create table beer_variants
(
    id int identity constraint PK_beer_variants PRIMARY KEY CLUSTERED not null,
    beer_id int constraint FK_beer_variants_beers references beers (id) on delete cascade,
    year date not null
)

create nonclustered index ix_beer_variants_beer_id
on beer_variants (beer_id)