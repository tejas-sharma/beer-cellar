# API 

## Entities 

```
type BeerCellar {
    id: ID!,
    name: String!,
    owner: User!,
    beers: [Beer!]!
}

type Beer {
    id: ID!,
    name: String!,
    brewer: Brewer!,
    variants: [BeerVariant]
}

type Brewer {
    id: ID!,
    name: String!,
    beers: [Beer!]!
}

type BeerVariant {
    id: ID!,
    year: String!,
    beer: Beer!
}

type User {
    id: ID!,
    firstName: String!,
    lastName: String!,
    cellars: [BeerCellars!]
}
```

## 