describe('Sign In And Register Test', () => {
  it('should_login_as_an_admin', () => {
    login("admin@admin.com", "Admin@123", "http://localhost:5246/signIn");
  });

  // it('should_register_and_login_correct', () => {
  //   var email = "thomas.pijper@gmail.com";
  //   var password = "Admin@123";
  //   var User =
  //   {
  //       "User": {
  //           "FirstName": "Thomas",
  //           "LastName": "Pijper",
  //           "Email": email,
  //           "Password": password,
  //           "ConfirmPassword": password,
  //           "candidateDto": {
  //               "dateOfBirth": "2024-05-30T09:51:12.150Z",
  //               "bsn": "string",
  //               "createdDate": "2024-05-30T09:51:12.150Z",
  //               "updatedDate": "2024-05-30T09:51:12.150Z"
  //           }
  //       }
  //   }

  //   register(user);
  //   login(email, password, "");
  // })
})

// function register(user){
// }

function login(email, password, url){
    cy.visit('http://localhost:5246/');

    cy.get('.signInButton').click();

    cy.get('#email').type(email);

    cy.get('.password-input').type(password);

    cy.get('.login-button').click();

    cy.url().should('eq', url);
}
