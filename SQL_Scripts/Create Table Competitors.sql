
<!-- Criação da tabela Competitors -->

CREATE TABLE IF NOT EXISTS public."Competitors"
(
    "IdCompetitor" integer NOT NULL GENERATED BY DEFAULT AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    "Name" character varying(150) COLLATE pg_catalog."default" NOT NULL,
    "Gender" character(1) COLLATE pg_catalog."default" NOT NULL,
    "AverageTemperature" double precision NOT NULL,
    "Weight" double precision NOT NULL,
    "Height" double precision NOT NULL,
    CONSTRAINT "PK_Competitors" PRIMARY KEY ("IdCompetitor")
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public."Competitors"
    OWNER to postgres;