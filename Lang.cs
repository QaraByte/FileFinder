namespace FileFinder;

using Microsoft.Win32;

public static class Lang
{
    private static string _current = "ru";
    public static string Current => _current;

    public static void Load()
    {
        using var key = Registry.CurrentUser.OpenSubKey(@"Software\BNSoftware\FileFinder");
        var val = key?.GetValue("Language") as string;
        if (val == "en") _current = "en";
    }

    public static void Switch()
    {
        _current = _current == "ru" ? "en" : "ru";
        using var key = Registry.CurrentUser.CreateSubKey(@"Software\BNSoftware\FileFinder");
        key.SetValue("Language", _current);
    }

    private static string S(string ru, string en) => _current == "ru" ? ru : en;

    // ── MainForm ──────────────────────────────────────────────────────────────
    public static string Found                 => S("Найдено:", "Found:");
    public static string FoundN(int n)         => S($"Найдено: {n}", $"Found: {n}");
    public static string DriveLabel            => S("Искать на:", "Search on:");
    public static string FilterLabel           => S("Поиск:", "Filter:");
    public static string FileTypesGroup        => S("Типы файлов", "File Types");
    public static string ChkTxt                => S("Текстовые файлы (*.txt)", "Text files (*.txt)");
    public static string ChkWord               => S("Документы Microsoft Word (*.doc, *.docx)", "Microsoft Word documents (*.doc, *.docx)");
    public static string ChkExcel              => S("Документы Microsoft Excel (*.xls, *.xlsx)", "Microsoft Excel documents (*.xls, *.xlsx)");
    public static string ChkPdf                => S("Документы PDF (*.pdf)", "PDF documents (*.pdf)");
    public static string ChkMp3                => S("Музыка mp3 (*.mp3)", "MP3 music (*.mp3)");
    public static string ChkPpt                => S("Презентации PowerPoint (*.ppt, *.pptx)", "PowerPoint presentations (*.ppt, *.pptx)");
    public static string ChkImg                => S("Изображения (*.jpg, *.png, *.gif, *.bmp)", "Images (*.jpg, *.png, *.gif, *.bmp)");
    public static string ProNotice             => S("PDF, MP3, презентации и картинки — только Pro", "PDF, MP3, presentations & images — Pro only");
    public static string BtnSearch             => S("Поиск", "Search");
    public static string BtnStop               => S("Стоп", "Stop");
    public static string BtnSave               => S("Сохранить результаты", "Save results");
    public static string StatusSearching       => S("Поиск...", "Searching...");
    public static string StatusStopped         => S("Поиск остановлен.", "Search stopped.");
    public static string StatusDone(int n)     => S($"Поиск завершён. Найдено: {n}", $"Search complete. Found: {n}");
    public static string MsgSelectType         => S("Выберите хотя бы один тип файлов.", "Please select at least one file type.");
    public static string SavedMsg(string path) => S($"Результаты сохранены:\n{path}", $"Results saved:\n{path}");
    public static string RestartToApply        => S("Перезапустите программу для смены языка.", "Restart the app to apply the language change.");

    // ── Context menu ──────────────────────────────────────────────────────────
    public static string MenuOpen              => S("Открыть", "Open");
    public static string MenuOpenFolder        => S("Открыть папку", "Open Folder");
    public static string MenuProperties        => S("Свойства", "Properties");

    // ── FilePropertiesDialog ──────────────────────────────────────────────────
    public static string PropTitle             => S("Свойства файла", "File Properties");
    public static string PropName              => S("Название:", "Name:");
    public static string PropPath              => S("Путь:", "Path:");
    public static string PropSize              => S("Размер:", "Size:");
    public static string PropAuthor            => S("Автор:", "Author:");
    public static string PropCreated           => S("Создан:", "Created:");

    // ── AboutDialog ───────────────────────────────────────────────────────────
    public static string TabAbout              => S("О программе", "About");
    public static string TabHelp               => S("Справка", "Help");
    public static string AboutAuthor           => S("Автор: N.Bexatov", "Author: N.Bexatov");
    public static string LicNotActivated       => S("Лицензия: не активирована", "License: not activated");
    public static string LicActive(DateTime d)  => S($"Лицензия: активна до {d:dd.MM.yyyy}", $"License: active until {d:dd.MM.yyyy}");
    public static string LicExpired(DateTime d) => S($"Лицензия: истекла {d:dd.MM.yyyy} — продлите подписку", $"License: expired {d:dd.MM.yyyy} — renew subscription");
    public static string BtnActivateLic        => S("Активировать лицензию...", "Activate license...");
    public static string BtnChangeLic          => S("Сменить лицензию...", "Change license...");
    public static string BtnRenewLic           => S("Продлить лицензию...", "Renew license...");

    // Help tab
    public static string HelpFileTypes         => S("Выбор типов файлов", "File Types");
    public static string HelpFileTypesBody     => S(
        "Отметьте нужные форматы в блоке «Типы файлов» (*.txt, *.doc, *.pdf и др.).",
        "Check the formats you need in the «File Types» panel (*.txt, *.doc, *.pdf, etc.).");
    public static string HelpDrive             => S("Выбор диска", "Drive Selection");
    public static string HelpDriveBody         => S(
        "В поле «Искать на:» выберите диск для поиска. Кнопка ↻ обновляет список подключённых дисков.",
        "In the «Search on:» field, select the drive to search. The ↻ button refreshes the list of connected drives.");
    public static string HelpSearch            => S("Поиск", "Search");
    public static string HelpSearchBody        => S(
        "Нажмите «Поиск» — программа рекурсивно просканирует все папки выбранного диска. " +
        "Во время поиска кнопка меняется на «Стоп» — нажмите для остановки.",
        "Click «Search» — the app will recursively scan all folders on the selected drive. " +
        "During search the button changes to «Stop» — click to cancel.");
    public static string HelpResults           => S("Список результатов", "Results List");
    public static string HelpResultsBody       => S(
        "Найденные файлы отображаются в списке результатов (большая область вверху окна):\r\n" +
        "  • двойной клик — открыть файл\r\n" +
        "  • правый клик — открывается контекстное меню (Открыть, Открыть папку, Свойства)",
        "Found files are displayed in the results list (the large area at the top of the window):\r\n" +
        "  • double-click — open the file\r\n" +
        "  • right-click — opens a context menu (Open, Open Folder, Properties)");
    public static string HelpFilter            => S("Фильтр по имени", "Name Filter");
    public static string HelpFilterBody        => S(
        "Поле «Поиск:» фильтрует список результатов по имени файла в реальном времени, без повторного поиска.",
        "The «Filter:» field filters the results list by file name in real time, without re-running the search.");
    public static string HelpSave              => S("Сохранить результаты", "Save Results");
    public static string HelpSaveBody          => S(
        "Кнопка «Сохранить результаты» сохраняет список в текстовый файл.",
        "The «Save results» button saves the list to a text file.");
    public static string HelpProHeader         => S("Лицензия Pro", "Pro License");
    public static string HelpProBody           => S(
        "Открывает дополнительные форматы: PDF, MP3, PowerPoint, изображения (JPG, PNG, GIF, BMP).",
        "Unlocks additional formats: PDF, MP3, PowerPoint, images (JPG, PNG, GIF, BMP).");

    // ── AboutDialog – version history ────────────────────────────────────────
    public static string HistoryText => S(
        "Версия 1.00 / 15.02.2017\r\n" +
        "Поиск файлов различных форматов (*.txt, *.doc, *.docx)\r\n" +
        "в каталогах пятого уровня на диске C.\r\n" +
        "\r\n" +
        "Версия 1.01 / 16.02.2017\r\n" +
        "- добавлены иконки файлов (Word, Excel, pdf)\r\n" +
        "- добавился поиск документов Microsoft Excel\r\n" +
        "- редизайн «Типов файлов»\r\n" +
        "- изменено окно «О программе»\r\n" +
        "\r\n" +
        "Версия 2.00 / 2026\r\n" +
        "- Полная переработка приложения\r\n" +
        "- Поддержка новых форматов: PDF, MP3, PowerPoint, изображения\r\n" +
        "- Лицензионная система Pro\r\n" +
        "- Добавлена справка\r\n" +
        "- Английский язык",
        "Version 1.00 / 15.02.2017\r\n" +
        "File search across various formats (*.txt, *.doc, *.docx)\r\n" +
        "in fifth-level directories on drive C.\r\n" +
        "\r\n" +
        "Version 1.01 / 16.02.2017\r\n" +
        "- added file icons (Word, Excel, pdf)\r\n" +
        "- added Microsoft Excel document search\r\n" +
        "- redesigned File Types panel\r\n" +
        "- updated About dialog\r\n" +
        "\r\n" +
        "Version 2.00 / 2026\r\n" +
        "- Full application rewrite\r\n" +
        "- Support for new formats: PDF, MP3, PowerPoint, images\r\n" +
        "- Pro licensing system\r\n" +
        "- Added help guide\r\n" +
        "- English language");

    // ── ActivateLicenseDialog ─────────────────────────────────────────────────
    public static string ActTitle              => S("Активация лицензии", "License Activation");
    public static string ActEmailPlaceholder   => S("ваш e-mail для лицензии", "your email for the license");
    public static string ActBtnGmail           => S("Написать (Gmail) для получения ключа — $5 / год", "Send email (Gmail) to get a license key — $5/year");
    public static string ActOr                 => S("или:", "or:");
    public static string ActKeyCaption         => S("Ключ:", "Key:");
    public static string ActBtnActivate        => S("Активировать", "Activate");
    public static string ActBtnClose           => S("Закрыть", "Close");
    public static string ActBtnCopy            => S("Копировать", "Copy");
    public static string ActCopied             => S("Скопировано!", "Copied!");
    public static string ActErrNoData          => S("Введите e-mail и ключ лицензии.", "Enter email and license key.");
    public static string ActErrBadEmail        => S("Введите корректный e-mail.", "Enter a valid email.");
    public static string ActSuccess(DateTime d) => S($"Лицензия активирована до {d:dd.MM.yyyy}.", $"License activated until {d:dd.MM.yyyy}.");
    public static string ActErrBadKey          => S("Неверный ключ или e-mail. Проверьте данные из письма.", "Invalid key or email. Check the data from the email.");
    public static string ActGmailSubject       => S("Лицензия FileFinder", "FileFinder License");
    public static string ActGmailBody(string email) => S(
        $"Здравствуйте!\n\nХочу купить лицензию FileFinder ($5/год).\n" +
        $"Мой e-mail для привязки ключа: {email}",
        $"Hello!\n\nI would like to purchase a FileFinder license ($5/year).\n" +
        $"My email for the license key: {email}");
}
