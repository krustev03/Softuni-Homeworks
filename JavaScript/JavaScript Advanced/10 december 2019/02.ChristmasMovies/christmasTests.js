let ChristmasMovies = require('./02. Christmas Movies_Resources');
let assert = require('chai').assert;

describe('SkiResort', function () 
{
    describe('constructor', function () 
    {
        it('check movieCollection', function () 
        {
            var movies = new ChristmasMovies();
            assert.deepEqual(movies.movieCollection, []);
        });
        it('check watched', function () 
        {
            var movies = new ChristmasMovies();
            assert.deepEqual(movies.watched, {});
        });
        it('check actors', function () 
        {
            var movies = new ChristmasMovies();
            assert.deepEqual(movies.actors, []);
        });
    });
    describe('buyMovie()', function () 
    {
        it('message', function () 
        {
            var movies = new ChristmasMovies();
            assert.deepEqual(movies.buyMovie("Movie", ["P1", "P2"]), 'You just got Movie to your collection in which P1, P2 are taking part!');
        });
        it('added in collection', function () 
        {
            var movies = new ChristmasMovies();
            movies.buyMovie("Movie", ["P1", "P2"]);
            assert.equal(movies.movieCollection[0].name, "Movie");
        });
        it('unique actors', function () 
        {
            var movies = new ChristmasMovies();
            movies.buyMovie("Movie", ["P1", "P1", "P2"]);
            assert.deepEqual(movies.movieCollection[0].actors, ['P1', 'P2']);
        })
        it('error', function () 
        {
            var movies = new ChristmasMovies();
            movies.buyMovie("Movie", ["P1", "P2"]);
            var actual = () => movies.buyMovie("Movie", ['P1', 'P2']);
            assert.throws(actual, 'You already own Movie in your collection!');
        });
    });
    describe('discardMovie()', function () 
    {
        it('not in collection', function () 
        {
            var movies = new ChristmasMovies();
            assert.throws(() => movies.discardMovie("Movie"), 'Movie is not at your collection!');
        });
        it('discard only movie', function () 
        {
            var movies = new ChristmasMovies();
            movies.buyMovie("Movie", ["P1", "P2"]);
            
            assert.throws(() => movies.discardMovie('Movie'), 'Movie is not watched!');
        });
        it('discard watched movie', function () 
        {
            var movies = new ChristmasMovies();
            movies.buyMovie("Movie", ["P1", "P2"]);
            movies.watchMovie('Movie');
            assert.deepEqual(movies.discardMovie("Movie"), 'You just threw away Movie!');
        })
    });
    describe('watchMovie()', function () 
    {
        it('not in collection', function () 
        {
            var movies = new ChristmasMovies();
            assert.throws(() => movies.watchMovie("Movie"), 'No such movie in your collection!');
        });
        it('watch it for first', function () 
        {
            var movies = new ChristmasMovies();
            movies.buyMovie("Movie", ["P1", "P2"]);
            movies.watchMovie('Movie');
            
            assert.deepEqual(movies.watched['Movie'], 1);
        });
        it('watch it not for first', function () 
        {
            var movies = new ChristmasMovies();
            movies.buyMovie("Movie", ["P1", "P2"]);
            movies.watchMovie('Movie');
            movies.watchMovie('Movie');
            
            assert.deepEqual(movies.watched['Movie'], 2);
        })
    });
    describe('favouriteMovie()', function () 
    {
        it('not watched movies', function () 
        {
            var movies = new ChristmasMovies();
            movies.buyMovie("Movie", ["P1", "P2"]);
            assert.throws(() => movies.favouriteMovie(), 'You have not watched a movie yet this year!');
        });
        it('have watched movies', function () 
        {
            var movies = new ChristmasMovies();
            movies.buyMovie("Movie", ["P1", "P2"]);
            movies.watchMovie('Movie');
            movies.watchMovie('Movie');
            movies.buyMovie("Kon", ["P1"]);
            movies.watchMovie('Kon');
            
            assert.deepEqual(movies.favouriteMovie(), `Your favourite movie is Movie and you have watched it 2 times!`);
        });
    });
    describe('mostStarredActor()', function () 
    {
        it('not movies in collection', function () 
        {
            var movies = new ChristmasMovies();
        
            assert.throws(() => movies.mostStarredActor(), 'You have not watched a movie yet this year!');
        });
        it('have movies', function () 
        {
            var movies = new ChristmasMovies();
            movies.buyMovie("Movie", ["P1", "P2"]);
            movies.buyMovie('Kon', ['P1']);
            
            assert.deepEqual(movies.mostStarredActor(), `The most starred actor is P1 and starred in 2 movies!`);
        });
    });
});