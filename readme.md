# ## Содержание

* [Основные команды](#основные-команды)

* [Работа с историей](#работа-с-историей)

* [Работа с ветками](#работа-с-ветками)

* [Работа с удаленными репозиториями](#работа-с-удаленными-репозиториями)



https://github.com/danilwww123/user-name.git
git remote add mem https://github.com/danilwww123/user-name.git

 **git init** - Создает локальный репозиторий в текущей папке.

- **git add** - Добавляет указанные файлы в репозиторий/в следующий commit.

    - **git add .** - Добавить все файлы в текущей папке.

    - **git add <Название файла>** - Добавить определенный файл.

- **git commit** - Фиксирует все произведенные изменения в новый "commit".

    - **git commit -a** - Включить в commit все файлы, когда-либо ранее включенные в репозиторий.

    - **git commit -m "<Описание>"** - Добавить описание к commit-у.

- **git diff** - Отображает все произведенные изменения с момента предыдущего commit-а.

    - **git diff <commit1> <commit2>** - Отображает изменения относительно двух commit-ов.

- **git status** - Отображает текущее состояние репозитория.

## Работа с историей 

- **git log** - Посмотреть историю commit-ов текущей ветки.

    - **git log --oneline** - Одна строка = один commit.

    - **git log --graph** - Отображает историю изменений в графическом виде.

- **git reflog** - Посмотреть всю историю действий репозитория.

- **git checkout <хэшкод commit-а>** - Посмотреть состояние проекта на момент выбранного commit-а. (Устанавливает указатель Head на выбранный commit.)



