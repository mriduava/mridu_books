import React from 'react';
import BookContextProvider from './contexts/BookContextProvider'

const App = () => {
  return (
    <div className="App">
      <BookContextProvider>
        <h1>MRIDU BOOKS</h1>
      </BookContextProvider>
    </div>
  );
}

export default App;