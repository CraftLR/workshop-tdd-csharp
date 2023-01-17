# <img src="https://raw.githubusercontent.com/CraftLR/workshop-git/main/src/main/resources/assets/logo.png" alt="class logo" class="logo"/> 

## La Rochelle Software Craftsmenship
* **Auteurs:** 
    * [Sébastien NEDJAR](mailto:sebastien.nedjar@univ-amu.fr)
* **Besoin d'aide ?**
    * Consulter et/ou créér des [issues](https://github.com/CraftLR/workshop-tdd-csharp/issues).
    * [Email](mailto:sebastien.nedjar@univ-amu.fr) pour toutes questions autres.

## Aperçu du workshop et objectifs d'apprentissage

L'objectif premier de cet atelier est de vous familiariser avec tous les nouveaux outils qui sont nécessaires pour produire du beau code. Cet atelier est à la fois une découverte des tests unitaires et de leur mise en pratique. Chacun des exercices proposés ci-après peut donner lieu à un kata que serait pratiqué lors d'un coding dojo en mob-programming pour questionner ses pratiques et les differents choix que l'on pourrait faire. 

## Découverte de l'environnement de travail, des outils et premiers tests en C#

### Création de votre fork

Vous connaissez déjà les bases de Git. Si ce n'est pas le cas, il vous faudra réaliser l'atelier [Git](https://github.com/CraftLR/workshop-git).

Cela sera indispensable pour commencer à travailler et garder trace de vos réalisation. Comme vous allez le découvrir le suivi de votre travail passe directement par GitHub grace à l'intégration continue.

La première chose à faire est de créer un fork de ce dépôt. Pour ce faire, rendez-vous sur le lien suivant :

[https://classroom.github.com/a/-E2YywoT](https://classroom.github.com/a/-E2YywoT)

GitHub va vous créer un dépôt contenant un fork de ce dépôt. Vous apparaîtrez automatiquement comme contributeur de ce projet pour y pousser votre travail.

### Découverte et prise en main de l'IDE

Pour faire l'atelier, il faut disposer d'un environnement dotnet et de préférence à jour. Pour en télécharger dotnet 6.0 sur une distribution linux, vous pouvez utiliser les commandes suivantes : 

```sh
cd
sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-6.0
```

Pour vérifier que vous avez bien la bonne version de dotnet configurée, vous pouvez exécuter la commande `dotnet --version` qui doit vous afficher la sortie suivante :

```sh
~$ dotnet --version
6.0.405
~$ 
```

Si vous disposez de docker et de Visual Studio Code, le projet peut être importé directement dans l'éditeur. Il vous sera demander d'ouvrir le projet dans un conteneur de développement qui s'occupera d'installer toutes les dépendances nécéssaires. Le téléchargement de l'image docker peut être longue si votre réseau n'a pas un débit important. Dans ce cas, il est possible de passer directement sur les IDE en ligne associé aux service GitHub CodeSpace ou Gitpod.

#### Configurer Gitpod

En cas de travail depuis une machine sur laquelle vous ne pouvez pas installer tous les outils, vous pouvez pour cet atelier utiliser le service Gitpod :

[![Open In Gitpod](https://gitpod.io/button/open-in-gitpod.svg)](https://gitpod.io/#https://github.com/CraftLR/workshop-tdd)

Pour disposer de Gitpod sur tous vos projets hébergés sur Github, suivez les étapes suivantes :

* Créez un compte Gitpod en vous rendant sur la page [Get started](https://www.gitpod.io/#get-started). Identifiez-vous avec votre compte github en cliquant sur le bouton "Continue with Github". Si vous avez le pack [Github Education](https://education.github.com/pack), vous pouvez bénéficier de l'offre 100h/mois. N'oubliez pas d'en faire la demande dans les [réglages de votre compte Gitpod](https://gitpod.io/plans).

* Installez l'[application Gitpod](https://github.com/apps/gitpod-io/installations/new). L'application GitHub de Gitpod est similaire à un serveur CI et préparera en permanence des pré-constructions pour toutes vos branches et demandes d'extraction - vous n'avez donc pas à attendre que Maven ou NPM télécharge Internet lorsque vous souhaitez commencer à travailler.

* Démarrez votre premier espace de travail avec une préconstruction en préfixant l'URL du référentiel par [https://gitpod.io#prebuild/](https://gitpod.io#prebuild/). Gitpod affiche l'état d'avancement de la pré-construction en exécutant les commandes `init` du fichier `.gitpod.yml` avant de démarrer un espace de travail. Plus tard, lorsque vous créez un nouvel espace de travail sur une branche, ou une Pull Request, l'espace de travail se charge beaucoup plus rapidement, car toutes les dépendances sont déjà téléchargées et le code est compilé.

* Installez de l'extension navigateur Gitpod sur tous les navigateurs basés sur [Chromium](https://chrome.google.com/webstore/detail/gitpod-always-ready-to-co/dodmmooeoklaejobgleioelladacbeki) (tels que Microsoft Edge, Brave, Chrome, ...) ou sur [Firefox](https://addons.mozilla.org/fr/firefox/addon/gitpod/). L'extension ajoute simplement un bouton Gitpod sur chaque projet et branche sur GitHub, et Bitbucket qui préfixe l'URL avec [http://gitpod.io/#](http://gitpod.io/#) afin que vous puissiez facilement ouvrir un nouvel espace de travail à partir de n'importe quel contexte Git.

* Personnalisez le thème par défaut en ouvrant le panneau de commande (avec le raccourci clavier `Ctrl+Shift+P`) et en sélectionnant `Preferences: Color Theme`. Si vous préférez par exemple les couleur sombre pour reposer vos yeux, le thème *gitpod dark* devrait vous convenir. Vous pouvez rajouter de nouveaux thème directement en recherchant dans les extensions (avec le raccourci clavier `Ctrl+Shift+X`).

Vous pouvez maintenant commencer à traiter les environnements de développement comme des ressources automatisées que vous lancez lorsque vous en avez besoin et fermez (et oubliez) lorsque vous avez terminé votre tâche. Les environnements de développement deviennent totalement éphémères. Attention avec l'offre Github éducation vous ne disposez que de 100h mensuels, donc il faut penser à fermer vos espaces de travail quand vous avez terminé de vous en servir (dans tous les cas ils seront fermés automatiquement après 30 minutes d'inactivité).

### Mode opératoire (Workflow)

Maintenant que vous savez utiliser Git en ligne de commande, que vous avez forké avec le lien classroom et importé le dépôt dans votre IDE, vous êtes en capacité de travailler sur les exercices ci-après.

Cet atelier est conçu pour vous faire découvrir les tests unitaires et le **Test Driven Development (TDD)**, c'est à dire le développement conduit par les tests.

Le TDD est une méthode de conception émergente selon laquelle la conception apparaît au fur et à mesure du développement en encourageant une meilleure compréhension du problème **en commençant à écrire les tests avant le code applicatif**. Pour le développeur, les tests vont constituer une spécification technique exécutable et vérifiable à tout moment. Ainsi en rajoutant des tests, le développeur converge progressivement à la fois vers une spécification plus fine et un code fonctionnel associé.

Le workflow du TDD est souvent décrit par le triptyque "RED, GREEN, REFACTOR" (figure empruntée au site [ministryoftesting](https://www.ministryoftesting.com)) :

![Cycle du TDD](src/main/resources/assets/graphic_tdd.png)

Nous vous proposons de suivre ce workflow particulier pour résoudre les exercices progressivement et en consolidant au fur et à mesure un filet de sécurité qui vérifiera que votre code continue à bien faire ce qu'il doit. Pour vous faciliter la découverte, pour cet atelier, les tests sont donnés pour s'habituer à cette méthodologie sans trop de douleur.

#### Étapes du cycle principal

Au cours de cet atelier, vous devrez donc opérer de manière similaire au TDD. Chaque exercice sera accompagné d'au moins une classe de test, dont tous les tests sont initialement désactivés. Pour réaliser l'exercice vous devrez suivre cycliquement les étapes suivantes (indiquées dans la figure précédente, illustrant le TDD) :

1. **RED :** Dans cette étape, vous devez activer un test en enlevant le `@Disabled` devant la méthode de test (ou en la décommentant). Une fois le test activé, vous devez le lancer pour vérifier qu'il échoue. Un test qui n'échoue jamais (comme celui de `AppTest`) ne teste rien donc il ne sert à rien.

1. **GREEN :** Ici vous devez écrire le moins de code possible pour faire passer le test en question. Quand vous pensez avoir terminé, vous relancez le test en question pour vérifier que le code est juste. Si tel est le cas, vous lancez tous les autres tests pour vous assurer que votre implémentation n'a rien cassé.

1. **REFACTOR :** Maintenant que votre couverture de test est au vert, vous pouvez transformer votre code pour le nettoyer, le restructurer et l'améliorer sans en changer le comportement. Pendant cette étape, les tests doivent être continuellement au vert. Ils jouent le rôle de filet de sécurité pour éviter l'introduction d'une régression dans le code. Quand tout est terminé vous pouvez redémarrer le cycle avec un prochain test.

**À chaque fin de cycle**, vous devez commiter votre travail sur votre dépôt Git local et le pousser sur votre fork sur GitHub. Vous terminez un exercice lorsque tous les tests y sont activés et passent sur votre dépôt distant.

#### Première exécution d'un test

Avant de commencer le premier exercice, commençons par exécuter un premier test pour vérifier que votre configuration est pleinement fonctionnelle. Ce test est aussi inutile que la classe `App` car il ne peut jamais échouer.

Ouvrez le fichier `AppTest.cs`, présent dans `/test/CraftLR.App.Tests`.

Il contient un seul test `MakeAVerySeriousTest()` qui s'assure que `true` est toujours vrai. La classe `AppTest` devrait être reconnue comme une classe de tests unitaires et apparaître avec l'annotation vous permettant de lancer tous les tests.

Pour exécuter uniquement ce test, utiliser l'annotation "Run Test" au dessus de la fonction. En bas de la fenêtre devrait s'afficher le résultat du test. S'il est passé avec succès, la ligne `Outcome: Passed` apparaitra en dessous du nom complet de la méthode de test.

### Exercice 1 : Hello world

Exercice d'introduction classique. Dites simplement "Hello world!"

"Hello world" est le premier programme que l'on écrit pour commencer la programmation dans un nouveau langage.

On considérera la résolution d'un exercice comme l'implementation d'une fonctionnalité. L'ensemble des modification devra donc avoir lieu dans une branche de fonctionnalité appelée `exercice1`. Pour la créer, vous devez exécuter les commandes suivantes dans le **terminal intégré de l'IDE** :

```sh
~/.../workshop-tdd-VotreUsername (main)$ git branch exercice1
~/.../workshop-tdd-VotreUsername (main)$ git checkout exercice1
~/.../workshop-tdd-VotreUsername (exercice1)$ 
```

**Les objectifs sont simples:**

* Vous devez activer les tests un par un.
* Commencez par le premier, lancez-le, il doit échouer. Implémentez ensuite la fonction de façon à ce qu'elle retourne `null`.
* Faites à nouveau tourner le test, il doit encore échouer. Puis implémentez la fonction pour qu'elle retourne "Hello, World!".
* Faites à nouveau tourner le test, il doit réussir.
* Vous recommencez ensuite ce travail pour chacun des tests suivants.
* Poussez votre solution sur GitHub.
* Si vous arrivez jusqu'au bout, vous serez prêt à travailler enfin sur votre premier exercice réel.

Bien évidemment l'implémentation qui vous est demandée n'est pas canonique mais elle illustre sur un exemple très simple ce qui vous sera demandé dans la suite des exercices. N'oubliez pas le workflow et surtout de ne passer à l'exercice suivant qu'après avoir activé tous les tests les uns après les autres.

Une fois l'exercice terminé, n'oubliez pas de pousser vos modifications sur votre fork de la manière suivante :

```sh
~/.../workshop-tdd-VotreUsername (exercice1*)$ mvn test
~/.../workshop-tdd-VotreUsername (exercice1*)$ git add test/CraftLR.Exercice1/HelloWorldTest.cs
~/.../workshop-tdd-VotreUsername (exercice1*)$ git add src/CraftLR.Exercice1/HelloWorld.cs
~/.../workshop-tdd-VotreUsername (exercice1*)$ git commit -m "Validation du dernier test de l'exercice 1"
~/.../workshop-tdd-VotreUsername (exercice1)$ git push origin exercice1
```

Une fois votre branche `exercice1` poussée sur votre dépôt distant, créez une pull request et invitez votre voisin à en faire la revue. Quand vous aurez terminé de faire les corrections suggérées par votre voisin, vous pourrez fusionner votre PR dans la branch principale `main`.

Pour continuer à travailler, une fois que vous avez fusionné la PR, vous devez vous replacer à nouveau sur la branche principale et tirer toutes les modifications de votre dépôt distant :

```sh
~/.../workshop-tdd-VotreUsername (exercice1)$ git checkout main
~/.../workshop-tdd-VotreUsername (main)$ git pull origin main
```

Après ces commandes, votre branche `main` locale sera enrichie des commits de votre dernière PR qui vient d'être mergée.

### Exercice 2 : Fizz Buzz

Le jeu du Fizz Buzz est un jeu sympa à organiser lors d’un anniversaire avec des enfants.

**But du jeu** : Les enfants doivent essayer de remplacer les nombres multiples de trois et cinq respectivement par les mots fizz et buzz : "Fizz" correspond aux multiples de "3" et "Buzz" aux multiples de "5".

**Déroulement du jeu** : Les enfants sont organisés en cercle. Vous désignez un premier enfant qui prononce le chiffre "un" à voix haute. Son voisin de gauche poursuit en prononçant le chiffre "deux". On continue ainsi jusqu’à ce que l’on arrive à un nombre multiple de 3 ou de 5. Le premier piège se situe donc au chiffre 3. L’enfant dont c’est le tour, devra donc dire "fizz" et non "trois".

Voici un exemple de série détaillée jusqu’à 20 :

1 ; 2 ; Fizz ; 4 ; Buzz ; Fizz ; 7 ; 8 ; Fizz ; Buzz ; 11 ; Fizz ; 13 ; 14 ; FizzBuzz ; 16 ; 17 ; Fizz ; 19 ; Buzz ;

Un enfant qui se trompe deux fois est éliminé.

L'objectif de cet exercice est d'implémenter une classe `FizzBuzzer` qui vous permettra de générer toute la série 'FizzBuzz' jusqu'à une valeur passée en paramètre.

Comme pour l'exercice précédent, vous devez activer les tests les uns après les autres et soumettre votre solution après chaque itération du cycle principal du workflow.

Ne pas oublier de créer une branche de fonctionnalité appelée `exercice2` avant de commencer. Pour la créer, vous devez exécuter les commandes suivantes :

```sh
~/.../workshop-tdd-VotreUsername (main)$ git branch exercice2
~/.../workshop-tdd-VotreUsername (main)$ git checkout exercice2
~/.../workshop-tdd-VotreUsername (exercice2)$ 
```

Une fois l'exercice terminé, n'oubliez pas de pousser vos modifications sur votre fork. Créez votre PR, faite la relire par votre voisin et fusionner là dès qu'elle est parfaite. Une fois la fusion effectuée, n'oubliez pas de vous replacer sur la branche `main` et de tirer votre dépôt distant.

### Exercice 3 : Convertisseur de nombre romain

La numération romaine est un système de numération additive utilisé par les Romains de l'Antiquité. Les chiffres romains sont représentés à l'aide de symboles combinés entre eux, notamment par les signes I, V, X, L, C, D et M, représentant respectivement les nombres 1, 5, 10, 50, 100, 500 et 1 000.

Un nombre écrit en chiffres romains se lit de gauche à droite. En première approximation, sa valeur se détermine en faisant la somme des valeurs individuelles de chaque symbole, sauf quand l'un des symboles précède un symbole de valeur supérieure ; dans ce cas, on soustrait la valeur du premier symbole au deuxième.

L'objectif de cet exercice est d'écrire une classe `ConvertisseurDeNombreRomain` qui aura une fonction qui prendra en paramètre un nombre romain et retournera sa représentation en une valeur entière.

**Indications :**

Les nombres romains sont majoritairement représentés selon les principes suivants :

* Un nombre en chiffres romains se lit de gauche à droite ;
* Un même symbole n'est pas employé quatre fois de suite (sauf M) ;
* Tout symbole qui suit un symbole de valeur supérieure ou égale s’ajoute à celui-ci (exemple : 6 s'écrit VI) ;
* Tout symbole qui précède un symbole de valeur supérieure se soustrait à ce dernier ;
  * I doit être retranché à V ou à X quand I est devant V ou X (ex. : 4 s'écrit IV),
  * X doit être retranché à L ou à C quand X est devant L ou C (ex. : 40 s'écrit XL),
  * C doit être retranché à D ou à M quand C est devant D ou M (ex. : 900 s'écrit CM),
  * Par contre, ôter I de L ou de C n'est pas pratiqué (49 s'écrit XLIX et non IL ; 99 s'écrit XCIX et pas IC) ;
* Les symboles sont groupés par ordre décroissant, sauf pour les valeurs à retrancher selon la règle précédente (ex. : 1030 s'écrit MXXX et non XXXM qui est une des façons de représenter 970).

Dans cet exercice, vous allez manipuler la classe [`string`](https://learn.microsoft.com/fr-fr/dotnet/api/system.string?view=net-7.0). Cette classe possède de nombreuses méthodes utilitaires pour manipuler facilement les chaines de caractères. Prenez un peu de temps pour survoler la documentation avant de commencer la résolution de cet exercice. Ici, vous utiliserez principalement une boucle `for` et la proprièté [`String.Chars[Int32]`](https://learn.microsoft.com/fr-fr/dotnet/api/system.string.chars?view=net-6.0#system-string-chars(system-int32)).

Faites très attention pour cet exercice de bien respecter le principe du TDD en ajoutant vraiment tout le temps la quantité minimale de code nécessaire à la validation des tests. Si vous suivez cette règle, il se résout très facilement alors qu'en l'abordant de manière générale, il comporte de nombreux pièges pouvant vous faire perdre un temps précieux.

Comme pour l'exercice précédent, vous devez activer les tests les uns après les autres et soumettre votre solution après chaque itération du cycle principal du workflow.

Après le troisième test, vous pouvez refactoriser en utilisant un switch. Ensuite, vous ajouterez les tests nécessaires pour les symboles L, C, D et M.
A la fin de l'implémentation de tous les symboles de base, vous pouvez refactoriser le switch en utilisant l'IDE qui vous propose "Extract method", que vous nommerez correctement, l'idée est de toujours écrire un code facile à relire et qui exprime bien l'intention de l'auteur.

Une fois l'exercice terminé, n'oubliez pas de pousser les modifications de la branche `exercice3` sur votre fork. Créez votre PR, faite la relire par votre voisin et fusionner là dès qu'elle est parfaite. Une fois la fusion effectuée, n'oubliez pas de vous replacer sur la branche `main` et de tirer votre dépôt distant.

### Exercice 4 : Simulateur de robot

L'installation d'essai d'une usine de robots nécessite un programme pour vérifier les mouvements du robot. Les robots ont trois mouvements possibles:

* tourner à droite
* tourner à gauche
* avancer

Les robots sont placés sur une grille hypothétique infinie, face à une direction cardinale particulière (nord, est, sud ou ouest) à des coordonnées {x, y}, par exemple, {3,8}, avec des coordonnées croissantes vers le nord et l'est.

Le robot reçoit alors un certain nombre d'instructions, auquel cas l'installation de tests vérifie la nouvelle position du robot et dans quelle direction il pointe.

La chaîne de caractères "RAALAL" signifie:

* Tournez à droite
* Avance deux fois
* Tournez à gauche
* Avance une fois
* Tournez encore à gauche

Supposons qu'un robot commence à {7, 3} face au nord. Ensuite, s'il exécute la séquence d'instructions ci-dessus il devrait se trouver aux coordonnées {9, 4} face à l'ouest.

**Indications :**

Pour mémoriser l'ensemble des instructions, nous ne pouvons pas connaître à l'avance le nombre d'instructions contenues dans la chaîne de commandes. Les tableaux ne sont donc pas adaptés. Nous allons utiliser un objet d’une classe implémentant l’interface `IEnumerable`, par exemple un `List`.

L’interface [`IEnumerable`](https://learn.microsoft.com/fr-fr/dotnet/api/system.collections.ienumerable?view=net-6.0) est très générale et définit ce qu’une classe collectionnant des objets devrait fournir comme méthodes.

Elle est implémentée et étendue par les nombreuses collections spécialisées comme les ensembles (`Set`) qui garantissent qu’un élément est unique dans la collection, les listes (`List`) où les éléments ont des positions, et de nombreuses autres classes et interfaces.

Puisque nous voulons afficher les instructions dans l’ordre de la séquence de commande, nous avons besoin d’une classe qui maintienne cet ordre et qui permette de le suivre lors du parcours. C’est ce qu’impose la classe `List` qui étend `IEnumerable`.

Nous avons tous les ingrédients pour résoudre notre problème, vous pouvez démarrer en respectant bien le workflow.

**Travail à faire :**

* Écrire une classe `Robot` représentant le robot à simuler.
* Écrire une classe `RobotSimulator` qui permet de passer une chaîne d'instructions à un robot et de piloter le fonctionnement du robot en fonction d'une séquence d'instructions passées en paramètre.
  
Comme pour l'exercice précédent, vous devez activer les tests les uns après les autres et soumettre votre solution après chaque itération du cycle principal du workflow.

Une fois l'exercice terminé, n'oubliez pas de pousser les modifications de la branche de fonctionnalité associée à l'exercice sur votre fork. Créez votre PR, faite la relire par votre voisin et fusionner là dès qu'elle est parfaite. Une fois la fusion effectuée, n'oubliez pas de vous replacer sur la branche `main` et de tirer votre dépôt distant.

### Exercice 5 : Démineur

Le démineur est un jeu de réflexion dont le but est de localiser des mines cachées dans un champ virtuel avec pour seule indication le nombre de mines dans les zones adjacentes.

Le champ de mines est représenté par une grille, qui peut avoir différentes formes : deux ou trois dimensions, pavage rectangulaire ou non, etc.

Chaque case de la grille peut soit cacher une mine, soit être vide. Le but du jeu est de découvrir toutes les cases libres sans faire exploser les mines, c'est-à-dire sans cliquer sur les cases qui les dissimulent.

Lorsque le joueur clique sur une case libre comportant au moins une mine dans l'une de ses cases avoisinantes, un chiffre apparaît, indiquant ce nombre de mines. Si en revanche toutes les cases adjacentes sont vides, une case vide est affichée et la même opération est répétée sur ces cases, et ce jusqu'à ce que la zone vide soit entièrement délimitée par des chiffres. En comparant les différentes informations récoltées, le joueur peut ainsi progresser dans le déminage du terrain. S'il se trompe et clique sur une mine, il a perdu.

#### Description du problème

Dans cet exercice, vous devez écrire le code qui compte le nombre de mines adjacentes à une case et transforme des tableaux comme celui-ci (où * indique une mine):

```
+-----+
| * * |
|  *  |
|  *  |
|     |
+-----+
```

En ceci :

```
+-----+
|1*3*1|
|13*31|
| 2*2 |
| 111 |
+-----+
```

**Travail à faire :**

* Écrire la classe `MinesweeperBoard` qui pour un tableau d'entrée avec les mines vous permettent de calculer le tableau avec les nombres.

Comme pour l'exercice précédent, vous devez activer les tests les uns après les autres et commiter votre solution après chaque itération du cycle principal du workflow.

Une fois l'exercice terminé, n'oubliez pas de pousser les modifications de la branche de fonctionnalité associée à l'exercice sur votre fork. Créez votre PR, faite la relire par votre voisin et fusionner là dès qu'elle est parfaite. Une fois la fusion effectuée, n'oubliez pas de vous replacer sur la branche `main` et de tirer votre dépôt distant.
