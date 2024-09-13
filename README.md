# Gestion_etat

## Description
Cette application permet de suivre les changements d'état des objets métier tout au long de leur cycle de vie. Chaque transition d'état est enregistrée avec une date et une description de l'événement qui a déclenché le changement, afin de retracer l'historique complet des états d'un objet.

## Fonctionnalités
- Suivi des changements d'état d'un objet métier avec un historique détaillé.
- Enregistrement de chaque changement avec la date de transition et une description de l'événement.
- Affichage de l'historique complet des états pour chaque objet.

## Prérequis
- .NET SDK 5.0 ou plus récent installé sur votre machine.

## Installation

1. **Cloner le dépôt** :
   git clone https://github.com/votre-utilisateur/suivi-changements-etats.git

## Choix Techniques

### 1. Classe `EtatHistorique`
- Cette classe représente une transition d'état. Elle contient quatre propriétés : PrevEtat, NextEtat, DateTime & Description
- La méthode ToString() retourne une chaîne de caractères formatée pour afficher les détails de la transition.

### 2. Classe `ObjetMetier`
- Cette classe représente un objet métier. Elle a deux membres principaux : _etatActuel,  _etatHistoriques (une liste qui stocke toutes les instances de EtatHistorique (les transitions d'état)) .
- La méthode ChangerEtat permet de changer l'état de l'objet. Si l'état actuel est différent du nouvel état, elle crée une nouvelle transition et la stocke dans l'historique.
- La méthode AfficherHistorique permet d'afficher tout l'historique des transitions.

### 3. Enum d'état
- Cet enum permet de centraliser tout les états possibles d'un objet et ainsi améliorer la lisibilité et la maintenabilité du code.

### 3. Gestion des transitions d'état
- Les transitions d'état sont gérées de manière centralisée dans l'objet métier à l'aide d'une méthode dédiée, `ChangerEtat(Etat nouvelEtat, string description)`.
- Cette méthode enregistre chaque changement dans l'historique d'états, en assurant que chaque transition est tracée avec précision.
- La séparation claire entre l'état actuel de l'objet et son historique permet de maintenir une trace complète des changements tout au long de son cycle de vie de plus l'instanciation de l'historique au début du cycle de 
  vie de l'objet et son encapsulation (private) rend impossible l'écrasement de l'historique et permet ainsi de garder un historique complet.
