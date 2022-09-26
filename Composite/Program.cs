using Composite;

BookComponent book =
    new Chapter("Book Title", new List<BookComponent>()
    {
        new Chapter("Chapter 1", new List<BookComponent>()
        {
            new Chapter("Chapter 1.1", new List<BookComponent>()
            {
                new Text("This is the text for chapter 1.1")
            }),
            new Chapter("Chapter 1.2", new List<BookComponent>()
            {
                new Text("This is the text for chapter 1.2")
            }),
            new Chapter("Chapter 1.3", new List<BookComponent>()
            {
                new Text("This is the text for chapter 1.3")
            })
        }),
        new Chapter("Chapter 2", new List<BookComponent>()
        {
            new Chapter("Chapter 2.1", new List<BookComponent>()
            {
                new Chapter("Chapter 2.1.1", new List<BookComponent>()
                {
                    new Text("This is the text for chapter 2.1.1")
                }),
                new Chapter("Chapter 2.1.2", new List<BookComponent>()
                {
                    new Text("This is the text for chapter 2.1.2")
                })
            }),
            new Chapter("Chapter 2.2", new List<BookComponent>()
            {
                new Text("This is the text for chapter 2.2")
            })
        })
    });


book.Print();