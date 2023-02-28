var Sequelize = require('sequelize');
var dbPath = 'bb-db.sqlite';

const sequelize = new Sequelize({
    dialect: 'sqlite',
    storage: dbPath
  });

sequelize
    .authenticate()
    .then(() => {
        console.log('Successful connection to database.');
    })
    .catch(err => {
        console.error('** Database connection failed: ', err);
        process.exit(1);
    });

var Event = sequelize.define('event', {
    title: Sequelize.STRING,
    detail: Sequelize.STRING,
    date: Sequelize.DATE
});

Event.sync();

exports.Events = Event;