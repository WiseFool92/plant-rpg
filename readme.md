# _Herb Rpg_

#### May 7th, 2020

## Description

_This console game is about plant life & accompanying hardships_

_This site is already linked to an index.html, styles.css, jQuery.js(3.4.1), scripts.js., main.js, jest, babel, lint, webpack, json, & gitignore_

## Setup/Installation Requirements

_Make sure you have [git version control](https://git-scm.com/downloads) installed on your computer._

1. Click the green 'Clone or Download' button and copy the link / download the zip
2. Open terminal and type... or skip to #4 if you downloaded the zip

**Windows**

```sh
cd desktop
```

Mac & linux

```sh
cd ~/Desktop
```

3.  in terminal type '_git clone {link to repository}_ '

```sh
git clone {link to repository}
```
4. If you downloaded the zip then extract all onto your desktop
5. Open the folder with VSC or an equivalent
6. Download .NET Core Sdk 3.1 & Run _dotnet -- version_ in the terminal to confirm installation
7. In the terminal Run _dotnet tool install -g dotnet-script_
8. Open project & Run _dotnet run_
9. Enjoy

## Specs

### Behavior Driven Development Spec List
#### Herb Rpg
|                          Behavior                          | Input  | Output  |
| :--------------------------------------------------------: | :----: | :-----: |
| The program will ask the user to name their plant | 'Mo' | 'Program displays beginning stats for named plant'  |
| The program will allow the user to water their plant | 'water' | 'grows an inch' |
| The user can grant the plant sunshine | 'Shine Sun' | 'grows a flower' |
| The user can feed their plant | 'feed' | 'health increases by 1' |
| After each user action, program randomly determines if something bad happens | 'user action' | '50% odds something bad will happen' |
| The users herb is hit by a | 'wind storm' | 'Subtracts an inch' |
| The players herb is hit by an | 'Aphid Attack' | 'health decreases by 1' |
| The users plant can be attacked by Slugs | 'Slug Bites' | 'Flowers decrease by 1' |



---
## Known Bugs

_N/A_ - 5/6/2020

## gh-pages

WiseFool92.github.io/plant-rpg

## Support

_Email: watkins92@gmail.com_

---
## Built With

- [HTML](https://developer.mozilla.org/en-US/docs/Web/HTML) - Simple Scaffolding
- [JavaScript](https://developer.mozilla.org/en-US/docs/Web/JavaScript) - Used for interactivity in the page
- [jQuery](https://jquery.com/) - Used to interact with the DOM
- [Bootstrap 4.4](https://getbootstrap.com/) - Used for styling

## Useful tools

- [free icons @ icons8](https://icons8.com/)
- [free icons @ fontawesome](https://fontawesome.com/)

---

- [Old School Gifs Search](https://gifcities.org/)
- [free images @ unsplash](https://unsplash.com/)

  - **_source.unsplash.com_ will return a random image at a desired size by simply calling the size after the url followed by a '?' and a keyword. Example below**

  - _https://source.unsplash.com/400x400/?cat_
  - http://unsplash.it/500/500 - This will just return a random image the size of 500x500

---

- [Flex-box Cheat Sheet](http://yoksel.github.io/flex-cheatsheet/)
- [CSS Grid Cheat Sheet](http://grid.malven.co/)

---

- [CSS Gradient BG Generator](https://mycolor.space/gradient)
- [CSS Basic Gradient Generator](https://cssgradient.io/)

---

- [CSS Dropshadow Generator](https://cssgenerator.org/box-shadow-css-generator.html)

### License

This project is licensed under the MIT License

Copyright (c) 2020 **_Nathan Watkins-Hoagland_**
