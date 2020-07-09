function solve() 
{
    class Post 
    {
        constructor(title, content) 
        {
            this.title = title;
            this.content = content;
        }

        toString() 
        {
            let result = `Post: ${this.title}\n`;
            result += `Content: ${this.content}`;
            return result;
        }
    }

    class SocialMediaPost extends Post 
    {
        constructor(title, content, likes, dislikes) 
        {
            super(title, content);
            this.likes = likes;
            this.dislikes = dislikes;
            this.comments = [];
        }

        addComment(comment) 
        {
            this.comments.push(comment);
        }

        toString() 
        {
            let result = `Post: ${this.title}\n`;
            result += `Content: ${this.content}\n`;
            result += `Rating: ${this.likes - this.dislikes}`;
            if(this.comments[0] !== undefined) 
            {
                result += `\nComments:\n`
                for (let i = 0; i < this.comments.length; i++) 
                {
                    if(i === this.comments.length - 1) 
                    {
                        result += ` * ${this.comments[i]}`;
                    }
                    else 
                    {
                        result += ` * ${this.comments[i]}\n`;
                    }
        
                }
            }
            return result;
        }
    }

    class BlogPost extends Post 
    {
        constructor(title, content, views) 
        {
            super(title, content);
            this.views = views;
        }

        view() 
        {
            this.views++;
            return this;
        }

        toString() 
        {
            let result = `Post: ${this.title}\n`;
            result += `Content: ${this.content}\n`;
            result += `Views: ${this.views}`;
            return result;
        }
    }

    return {Post, SocialMediaPost, BlogPost};
}