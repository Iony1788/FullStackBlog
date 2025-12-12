import React from "react";
import 'bootstrap/dist/css/bootstrap.min.css';
import '../styles/Home.css';

function Home() {
  return (
    <div className="container mt-4 home-page">
      <div className="row align-items-center">
        <div className="col-md-6">
          <h2 className="mb-3">Home Page</h2>
          <a href="/blog" className="btn btn-primary mt-3">Go to Blog Posts</a>
        </div>
        <div className="col-md-6">
          <img 
            src="/imageHome.jpg" 
            alt="" 
            className="img-fluid rounded shadow"
          />
        </div>
      </div>
    </div>
  );
}

export default Home;
