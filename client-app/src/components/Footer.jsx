import React from "react";
import 'bootstrap/dist/css/bootstrap.min.css';

function Footer() {
  return (
    <footer
      className="text-white text-center text-md-start py-3 mt-4"
      style={{ backgroundColor: "rgba(59, 61, 67, 1)" }}
    >
      <div className="container">
        <div className="row">
          <div className="col-12 col-md text-center text-md-start">
            <p className="mb-0">&copy; 2025 Client App. All rights reserved.</p>
          </div>
        </div>
      </div>
    </footer>
  );
}

export default Footer;
